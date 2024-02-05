function s2cParse(text) {
    const data = [];

    let height = 0;
    let width = 0;

    text = text.replace(/0x/g, "");

    text.split('\n').forEach(() => {
        text.split('\n')[height].split(';').forEach((f) => {
            data.push({
                height: height,
                width: width,
                text: f
            });
            width++;
        });
        height++;
    });

    return data;
}

function visualize(text, output) {
    var objects = s2cParse(text);

    let last_height = 0;
    objects.forEach((o) => {
        let request_newline = false;

        if (o.height > last_height) {
            last_height++;
            request_newline = true;
        }

        if (request_newline) {
            var br = document.createElement("br");
            output.appendChild(br);
        }

        var px = document.createElement("div");
        px.className = "s2c-single-pixel";
        console.log(`[DEBUG]: BG color is ${o.text}`);
        px.style.backgroundColor = o.text;

        output.appendChild(px);
    });
}
