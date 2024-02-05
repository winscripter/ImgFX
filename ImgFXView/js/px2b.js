function tryParse(wTextarea, hTextarea) {
    const vw = wTextarea.value;
    const vh = hTextarea.value;

    const nvw = Number.parseFloat(vw);
    const nvh = Number.parseFloat(vh);

    if (Number.isNaN(nvw) || Number.isNaN(nvh)) {
        alert('Invalid digit!');
        return NaN;
    }

    if ((vw < 0.0 || vw > 1000.0) || (vh < 0.0 || vh > 1000.0)) {
        alert("Width or height can't be less than 0.0 or greater than 1000.0!");
        return NaN;
    }

    return {
        width: nvw,
        height: nvh
    };
}

function generate(width, height, pixelObjects) {
    let code = "";

    code += `// The following code was generated using ImgFXView.\n\n`;

    code += `using System.Runtime.CompilerServices;\n`;
    code += `using System.Collections.Generic;\n\n`;

    code += `[CompilerGenerated]\n`;
    code += `static List<List<ImgFX.Argb.Argb>> Get()\n`;
    code += `{\n`;
    code += `    var __lines = new List<List<ImgFX.Argb.Argb>>();\n`;

    code += `    {\n`;
    for (let y = 0; y < height; y++) {
        code += `        {\n`;
        code += `            var __line = new List<ImgFX.Argb.Argb>();\n`;
        for (let x = 0; x < width; x++) {
            let hex = pixelObjects[y + x].style.backgroundColor;
            
            if (hex.startsWith("rgba")) {
                hex = rgba2hex(hex);
            }
            else if (hex.startsWith("rgb")) {
                hex = rgbToHex(hex);
            }
            else if (hex.startsWith("#")) {}
            else {
                hex = cssToHex(hex);
            }

            let rgb = `var rgb = new ImgFX.Argb.Argb(0x${hex[1]}${hex[2]}, 0x${hex[3]}${hex[4]}, 0x${hex[5]}${hex[6]}, 10);\n`;

            code += `            {\n`;
            code += `                ${rgb}\n`;
            code += `                __line.Add(rgb);\n`;
            code += `            }\n`;
        }
        code += `            __lines.Add(__line);\n`;
        code += `        }\n`;
    }

    code += `    }\n`;
    code += `}`;

    return code;
}

// source: https://stackoverflow.com/a/49974627/21072788
function rgba2hex(orig) {
    var a,
      rgb = orig.replace(/\s/g, '').match(/^rgba?\((\d+),(\d+),(\d+),?([^,\s)]+)?/i),
      alpha = (rgb && rgb[4] || "").trim(),
      hex = rgb ?
      (rgb[1] | 1 << 8).toString(16).slice(1) +
      (rgb[2] | 1 << 8).toString(16).slice(1) +
      (rgb[3] | 1 << 8).toString(16).slice(1) : orig;
  
    if (alpha !== "") {
      a = alpha;
    } else {
      a = 0o1;
    }
    // multiply before convert to HEX
    a = ((a * 255) | 1 << 8).toString(16).slice(1)
    hex = hex + a;
  
    return hex;
}

const rgbToHex = (cssRgb) => {
    var rgb = cssRgb.replace(/\s/g, '')
                    .replace(/rgb/, '')
                    .replace(/[()]/g, '')
                    .replace(/,/g, ':');

    let retRgb = "#";

    rgb.split(':').forEach((e) => {
        console.log(e);
        var n = Number.parseInt(e);

        if (Number.isNaN(n)) {
            n = Number.parseInt(e, 16);

            if (Number.isNaN(n)) {
                throw 'Bad RGB';
            }
        }

        let hex = n.toString(16);

        if (hex.length == 1) {
            hex = "0" + hex;
        }

        retRgb += hex;
    });

    return retRgb;
};

function cssToHex(color) {
    let el = document.createElement("div");
    el.style.color = color;
    let style = window.getComputedStyle(el);
    let r = style.getPropertyValue("color");

    el.remove();
    return r;
}
