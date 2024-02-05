const e_s2c = document.getElementById('s2c');
const home = document.getElementById('home-page');
const e_s2cstart = document.getElementById('s2c-start');
const s2cstart_back = document.getElementById('s2cstart-back');
const s2cv_back = document.getElementById('s2cv-back');
const s2c_visualize = document.getElementById('s2c-visualize');
const start_s2c = document.getElementById('start-s2c');
const s2c_syntax = document.getElementById('s2c-syntax');
const visualized_result = document.getElementById('visualized-result');
const pixel_size = document.getElementById('px-size');
const px_size_apply = document.getElementById('px-size-apply');
const px2b = document.getElementById('px2b');
const px2b_start = document.getElementById('px2b-start');
const px2bstart_back = document.getElementById('px2bstart-back');
const px2bx = document.getElementById('px2b-x');
const px2by = document.getElementById('px2b-y');
const px2bui = document.getElementById('px2b-ui');
const px2bui_back = document.getElementById('px2bui-back');
const px2b_begin = document.getElementById('px2b-begin');
const input_pixels = document.getElementById('input-pixels');
const color_pixel = document.getElementById('color-pixel');
const px2b_fillall = document.getElementById('px2b-fillall');
const px2b_applycolor = document.getElementById('px2b-applycolor');
const modal_code = document.getElementById('modal-code');
const px2bresult = document.getElementById('px2bresult');
const px2b_cv2cs = document.getElementById('px2b-cv2cs');

let px2bheight = 0;
let px2bwidth = 0;

e_s2c.addEventListener('click', () => {
    home.style.display = "none";
    e_s2cstart.style.display = "block";
});

s2cstart_back.addEventListener('click', () => {
    home.style.display = "block";
    e_s2cstart.style.display = "none";
});

s2cv_back.addEventListener('click', () => {
    home.style.display = "none";
    e_s2cstart.style.display = "block";
    s2c_visualize.style.display = "none";
});

start_s2c.addEventListener('click', () => {
    home.style.display = "none";
    e_s2cstart.style.display = "none";
    s2c_visualize.style.display = "block";

    removeAllPixels();

    visualize(s2c_syntax.value, visualized_result);
});

px_size_apply.addEventListener('click', () => {
    var pxs = pixel_size.value;

    var pxsn = Number.parseFloat(pxs);

    if (Number.isNaN(pxsn)) {
        alert("Invalid digit!");
    }
    else if (pxsn < 0.0) {
        alert("Size can't be less than 0!");
    }
    else if (pxsn > 1000.0) {
        alert("Wow, you're probably joking around! Size can't be greater than 1000.");
    }
    else {
        Array.from(document.getElementsByClassName("s2c-single-pixel")).forEach((e) => {
            e.style.height = `${pxsn}px`;
            e.style.width = `${pxsn}px`;
        });
    }
});

px2b.addEventListener('click', () => {
    px2b_start.style.display = 'block';
    home.style.display = "none";
});

px2bstart_back.addEventListener('click', () => {
    px2b_start.style.display = 'none';
    home.style.display = "block";
});

let color_of_any_pixel = "white";

px2b_begin.addEventListener('click', () => {
    var widthHeight = tryParse(px2bx, px2by);

    if (!Number.isNaN(widthHeight)) {
        removeAllPixels();

        px2bheight = widthHeight.height;
        px2bwidth = widthHeight.width;

        for (let y = 0; y < widthHeight.height; y++) {
            for (let x = 0; x < widthHeight.width; x++) {
                var obj = document.createElement("div");
                obj.classList.add("s2c-visualized-result");
                obj.classList.add("px2b-pixel");
                obj.classList.add("s2c-single-pixel");
                obj.style.cursor = "pointer";
                obj.style.height = "24px";
                obj.style.width = "24px";
                obj.style.resize = "none";
                obj.style.backgroundColor = "white";
                obj.style.border = "1px solid black";
                obj.style.display = "inline-block";

                input_pixels.appendChild(obj);

                resetAllPixelListeners();
            }
            var br = document.createElement("br");
            input_pixels.appendChild(br);
        }
    }

    px2b_start.style.display = 'none';
    home.style.display = "none";
    px2bui.style.display = "block";

    fill();
});

px2bui_back.addEventListener('click', () => {
    px2b_start.style.display = 'block';
    home.style.display = "none";
    px2bui.style.display = "none";
});

px2b_fillall.addEventListener('click', fill);

px2b_applycolor.addEventListener('click', applyColor);

function fill() {
    applyColor();

    Array.from(
        document.getElementsByClassName('px2b-pixel')
    )
    .forEach((e) => {
        e.style.backgroundColor = color_of_any_pixel;
    });
}

function applyColor() {
    var cp = color_pixel.value;

    color_of_any_pixel = cp;
}

function click(e) {
    e.target.style.backgroundColor = color_of_any_pixel;
}

function removeAllPixelListeners() {
    const elements = document.getElementsByClassName("px2b-pixel");
    Array.from(elements).forEach((e) => {
        e.removeEventListener('click', click);
    });
}

function setAllPixelListeners() {
    const elements = document.getElementsByClassName("px2b-pixel");
    Array.from(elements).forEach((e) => {
        e.addEventListener('click', click);
    });
}

function resetAllPixelListeners() {
    removeAllPixelListeners();
    setAllPixelListeners();
}

function removeAllPixels() {
    Array.from(document.getElementsByClassName("s2c-single-pixel")).forEach((e) => {
        e.remove();
    });
}

function turnGridToCSharp() {
    let objects = Array.from(document.getElementsByClassName("px2b-pixel"));

    let code = generate(px2bheight, px2bwidth, objects);
    px2bresult.textContent = code;
    modal_code.style.display = "block";
}

px2b_cv2cs.addEventListener('click', turnGridToCSharp);
