# imgfx
ImgFX lets you edit and get more info about images.

# PNG Information
Use `ImgFX.Png.PngContext` to achieve information about a Portable Network Graphics (PNG) image format, like:

```cs
using ImgFX.Png;

var ctx = new PngContext(File.ReadAllBytes("sillycat.png"));
Console.WriteLine($"{ctx.Width}x{ctx.Height}"); // 1920x1080

// you can use other properties, like .IHDR, .Chunks, etc.
```

# Font Information
Fonts aren't that easy to use in ImgFX, because you need to write your own one in black & white. ImgFX does support TTFs,
but it doesn't support converting them to `FontContext`. But you can create one yourself:

```cs
using ImgFX.Fonts;

var table = new FontTextTable(
    5, // height of the image in pixels
    3, // width of the image in pixels
    100, // scaling for this character in font (100%)
    65, // unicode representation for A
    new bool[]
    {
        true, true, true,   //    ######
        true, false, true,  //    ##--##
        true, true, true,   //    ######
        true, false, true,  //    ##--##
        true, false, true   //    ##--##   
    }
);

var cxt = new FontContext(
    "ImgFX Test Font",
    new FontTextTable[] { table }
);
```

# RGB & RGBA
Specify RGB and RGBA colors easily.

```cs
using ImgFX.Argb;
using ImgFX.Rgb;

var rgba = new Argb(0xFF, 0x00, 0x00, 10); // opacity is 1.0
var rgb = new Rgb(0xFF, 0x00, 0x00);

Console.WriteLine(rgb.ToCssRgb());
Console.WriteLine(rgb.ToCssRgba());
```

# This is not it!
There's more what ImgFX is capable of. The basics is enough for now!
