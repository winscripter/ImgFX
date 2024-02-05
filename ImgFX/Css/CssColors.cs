namespace ImgFX.Css;

// RRRRRR  EEEEEE  AAAAAA  DDDD
// RRRRRR  EEEEEE  AAAAAA  DDDD
// RR  RR  EE      AA  AA  DD  DD
// RR  RR  EE      AA  AA  DD  DD
// RRRR    EEEE    AAAAAA  DD  DD
// RRRR    EEEE    AAAAAA  DD  DD
// RR  RR  EE      AA  AA  DD  DD
// RR  RR  EE      AA  AA  DD  DD
// RR  RR  EEEEEE  AA  AA  DDDD
// RR  RR  EEEEEE  AA  AA  DDDD
//
// P     L     E     A     S     E
//  P     L     E     A     S     E
//   P     L     E     A     S     E
// 
// ------------------------------------
//
// If you're looking at this file only to look at some
// code, here's a fact. This file isn't any real code.
// Those thousands of lines of code are read-only
// dictionaries representing CSS colors. They were all
// generated using a tool, but you can use them if you
// need to convert CSS colors into RGB or Hex.
// You can also use or steal CssColors.lowercase.properties,
// CssColors.properties, and CssColors.uppercase.properties,
// which contain lowercase, normal, and uppercase CSS colors and
// their hex values, respectively. You ARE permitted to do that.
// Just don't mention you wrote all of it, give us your credit for
// our hard work, don't just undermine it ;)
// Don't waste your time!
// 
// ------------------------------------

/// <summary>
/// Represents CSS colors and their values in RGB, Hex, and RGBA.
/// </summary>
public static class CssColors
{
    /// <summary>
    /// Represents all CSS colors and their RGB values
    /// </summary>
    public static readonly Dictionary<string, Rgb.Rgb> CssToRgbColors = new()
    {
        {
            "AliceBlue",
            new Rgb.Rgb(0xF0, 0xF8, 0xFF)
        },
        {
            "AntiqueWhite",
            new Rgb.Rgb(0xFA, 0xEB, 0xD7)
        },
        {
            "Aqua",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "Aquamarine",
            new Rgb.Rgb(0x7F, 0xFF, 0xD4)
        },
        {
            "Azure",
            new Rgb.Rgb(0xF0, 0xFF, 0xFF)
        },
        {
            "Beige",
            new Rgb.Rgb(0xF5, 0xF5, 0xDC)
        },
        {
            "Bisque",
            new Rgb.Rgb(0xFF, 0xE4, 0xC4)
        },
        {
            "Black",
            new Rgb.Rgb(0x00, 0x00, 0x00)
        },
        {
            "BlanchedAlmond",
            new Rgb.Rgb(0xFF, 0xEB, 0xCD)
        },
        {
            "Blue",
            new Rgb.Rgb(0x00, 0x00, 0xFF)
        },
        {
            "BlueViolet",
            new Rgb.Rgb(0x8A, 0x2B, 0xE2)
        },
        {
            "Brown",
            new Rgb.Rgb(0xA5, 0x2A, 0x2A)
        },
        {
            "BurlyWood",
            new Rgb.Rgb(0xDE, 0xB8, 0x87)
        },
        {
            "CadetBlue",
            new Rgb.Rgb(0x5F, 0x9E, 0xA0)
        },
        {
            "Chartreuse",
            new Rgb.Rgb(0x7F, 0xFF, 0x00)
        },
        {
            "Chocolate",
            new Rgb.Rgb(0xD2, 0x69, 0x1E)
        },
        {
            "Coral",
            new Rgb.Rgb(0xFF, 0x7F, 0x50)
        },
        {
            "CornflowerBlue",
            new Rgb.Rgb(0x64, 0x95, 0xED)
        },
        {
            "Cornsilk",
            new Rgb.Rgb(0xFF, 0xF8, 0xDC)
        },
        {
            "Crimson",
            new Rgb.Rgb(0xDC, 0x14, 0x3C)
        },
        {
            "Cyan",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "DarkBlue",
            new Rgb.Rgb(0x00, 0x00, 0x8B)
        },
        {
            "DarkCyan",
            new Rgb.Rgb(0x00, 0x8B, 0x8B)
        },
        {
            "DarkGoldenRod",
            new Rgb.Rgb(0xB8, 0x86, 0x0B)
        },
        {
            "DarkGray",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "DarkGrey",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "DarkGreen",
            new Rgb.Rgb(0x00, 0x64, 0x00)
        },
        {
            "DarkKhaki",
            new Rgb.Rgb(0xBD, 0xB7, 0x6B)
        },
        {
            "DarkMagenta",
            new Rgb.Rgb(0x8B, 0x00, 0x8B)
        },
        {
            "DarkOliveGreen",
            new Rgb.Rgb(0x55, 0x6B, 0x2F)
        },
        {
            "DarkOrange",
            new Rgb.Rgb(0xFF, 0x8C, 0x00)
        },
        {
            "DarkOrchid",
            new Rgb.Rgb(0x99, 0x32, 0xCC)
        },
        {
            "DarkRed",
            new Rgb.Rgb(0x8B, 0x00, 0x00)
        },
        {
            "DarkSalmon",
            new Rgb.Rgb(0xE9, 0x96, 0x7A)
        },
        {
            "DarkSeaGreen",
            new Rgb.Rgb(0x8F, 0xBC, 0x8F)
        },
        {
            "DarkSlateBlue",
            new Rgb.Rgb(0x48, 0x3D, 0x8B)
        },
        {
            "DarkSlateGray",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "DarkSlateGrey",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "DarkTurquoise",
            new Rgb.Rgb(0x00, 0xCE, 0xD1)
        },
        {
            "DarkViolet",
            new Rgb.Rgb(0x94, 0x00, 0xD3)
        },
        {
            "DeepPink",
            new Rgb.Rgb(0xFF, 0x14, 0x93)
        },
        {
            "DeepSkyBlue",
            new Rgb.Rgb(0x00, 0xBF, 0xFF)
        },
        {
            "DimGray",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "DimGrey",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "DodgerBlue",
            new Rgb.Rgb(0x1E, 0x90, 0xFF)
        },
        {
            "FireBrick",
            new Rgb.Rgb(0xB2, 0x22, 0x22)
        },
        {
            "FloralWhite",
            new Rgb.Rgb(0xFF, 0xFA, 0xF0)
        },
        {
            "ForestGreen",
            new Rgb.Rgb(0x22, 0x8B, 0x22)
        },
        {
            "Fuchsia",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "Gainsboro",
            new Rgb.Rgb(0xDC, 0xDC, 0xDC)
        },
        {
            "GhostWhite",
            new Rgb.Rgb(0xF8, 0xF8, 0xFF)
        },
        {
            "Gold",
            new Rgb.Rgb(0xFF, 0xD7, 0x00)
        },
        {
            "GoldenRod",
            new Rgb.Rgb(0xDA, 0xA5, 0x20)
        },
        {
            "Gray",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "Grey",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "Green",
            new Rgb.Rgb(0x00, 0x80, 0x00)
        },
        {
            "GreenYellow",
            new Rgb.Rgb(0xAD, 0xFF, 0x2F)
        },
        {
            "HoneyDew",
            new Rgb.Rgb(0xF0, 0xFF, 0xF0)
        },
        {
            "HotPink",
            new Rgb.Rgb(0xFF, 0x69, 0xB4)
        },
        {
            "IndianRed",
            new Rgb.Rgb(0xCD, 0x5C, 0x5C)
        },
        {
            "Indigo",
            new Rgb.Rgb(0x4B, 0x00, 0x82)
        },
        {
            "Ivory",
            new Rgb.Rgb(0xFF, 0xFF, 0xF0)
        },
        {
            "Khaki",
            new Rgb.Rgb(0xF0, 0xE6, 0x8C)
        },
        {
            "Lavender",
            new Rgb.Rgb(0xE6, 0xE6, 0xFA)
        },
        {
            "LavenderBlush",
            new Rgb.Rgb(0xFF, 0xF0, 0xF5)
        },
        {
            "LawnGreen",
            new Rgb.Rgb(0x7C, 0xFC, 0x00)
        },
        {
            "LemonChiffon",
            new Rgb.Rgb(0xFF, 0xFA, 0xCD)
        },
        {
            "LightBlue",
            new Rgb.Rgb(0xAD, 0xD8, 0xE6)
        },
        {
            "LightCoral",
            new Rgb.Rgb(0xF0, 0x80, 0x80)
        },
        {
            "LightCyan",
            new Rgb.Rgb(0xE0, 0xFF, 0xFF)
        },
        {
            "LightGoldenRodYellow",
            new Rgb.Rgb(0xFA, 0xFA, 0xD2)
        },
        {
            "LightGray",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "LightGrey",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "LightGreen",
            new Rgb.Rgb(0x90, 0xEE, 0x90)
        },
        {
            "LightPink",
            new Rgb.Rgb(0xFF, 0xB6, 0xC1)
        },
        {
            "LightSalmon",
            new Rgb.Rgb(0xFF, 0xA0, 0x7A)
        },
        {
            "LightSeaGreen",
            new Rgb.Rgb(0x20, 0xB2, 0xAA)
        },
        {
            "LightSkyBlue",
            new Rgb.Rgb(0x87, 0xCE, 0xFA)
        },
        {
            "LightSlateGray",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "LightSlateGrey",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "LightSteelBlue",
            new Rgb.Rgb(0xB0, 0xC4, 0xDE)
        },
        {
            "LightYellow",
            new Rgb.Rgb(0xFF, 0xFF, 0xE0)
        },
        {
            "Lime",
            new Rgb.Rgb(0x00, 0xFF, 0x00)
        },
        {
            "LimeGreen",
            new Rgb.Rgb(0x32, 0xCD, 0x32)
        },
        {
            "Linen",
            new Rgb.Rgb(0xFA, 0xF0, 0xE6)
        },
        {
            "Magenta",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "Maroon",
            new Rgb.Rgb(0x80, 0x00, 0x00)
        },
        {
            "MediumAquaMarine",
            new Rgb.Rgb(0x66, 0xCD, 0xAA)
        },
        {
            "MediumBlue",
            new Rgb.Rgb(0x00, 0x00, 0xCD)
        },
        {
            "MediumOrchid",
            new Rgb.Rgb(0xBA, 0x55, 0xD3)
        },
        {
            "MediumPurple",
            new Rgb.Rgb(0x93, 0x70, 0xDB)
        },
        {
            "MediumSeaGreen",
            new Rgb.Rgb(0x3C, 0xB3, 0x71)
        },
        {
            "MediumSlateBlue",
            new Rgb.Rgb(0x7B, 0x68, 0xEE)
        },
        {
            "MediumSpringGreen",
            new Rgb.Rgb(0x00, 0xFA, 0x9A)
        },
        {
            "MediumTurquoise",
            new Rgb.Rgb(0x48, 0xD1, 0xCC)
        },
        {
            "MediumVioletRed",
            new Rgb.Rgb(0xC7, 0x15, 0x85)
        },
        {
            "MidnightBlue",
            new Rgb.Rgb(0x19, 0x19, 0x70)
        },
        {
            "MintCream",
            new Rgb.Rgb(0xF5, 0xFF, 0xFA)
        },
        {
            "MistyRose",
            new Rgb.Rgb(0xFF, 0xE4, 0xE1)
        },
        {
            "Moccasin",
            new Rgb.Rgb(0xFF, 0xE4, 0xB5)
        },
        {
            "NavajoWhite",
            new Rgb.Rgb(0xFF, 0xDE, 0xAD)
        },
        {
            "Navy",
            new Rgb.Rgb(0x00, 0x00, 0x80)
        },
        {
            "OldLace",
            new Rgb.Rgb(0xFD, 0xF5, 0xE6)
        },
        {
            "Olive",
            new Rgb.Rgb(0x80, 0x80, 0x00)
        },
        {
            "OliveDrab",
            new Rgb.Rgb(0x6B, 0x8E, 0x23)
        },
        {
            "Orange",
            new Rgb.Rgb(0xFF, 0xA5, 0x00)
        },
        {
            "OrangeRed",
            new Rgb.Rgb(0xFF, 0x45, 0x00)
        },
        {
            "Orchid",
            new Rgb.Rgb(0xDA, 0x70, 0xD6)
        },
        {
            "PaleGoldenRod",
            new Rgb.Rgb(0xEE, 0xE8, 0xAA)
        },
        {
            "PaleGreen",
            new Rgb.Rgb(0x98, 0xFB, 0x98)
        },
        {
            "PaleTurquoise",
            new Rgb.Rgb(0xAF, 0xEE, 0xEE)
        },
        {
            "PaleVioletRed",
            new Rgb.Rgb(0xDB, 0x70, 0x93)
        },
        {
            "PapayaWhip",
            new Rgb.Rgb(0xFF, 0xEF, 0xD5)
        },
        {
            "PeachPuff",
            new Rgb.Rgb(0xFF, 0xDA, 0xB9)
        },
        {
            "Peru",
            new Rgb.Rgb(0xCD, 0x85, 0x3F)
        },
        {
            "Pink",
            new Rgb.Rgb(0xFF, 0xC0, 0xCB)
        },
        {
            "Plum",
            new Rgb.Rgb(0xDD, 0xA0, 0xDD)
        },
        {
            "PowderBlue",
            new Rgb.Rgb(0xB0, 0xE0, 0xE6)
        },
        {
            "Purple",
            new Rgb.Rgb(0x80, 0x00, 0x80)
        },
        {
            "RebeccaPurple",
            new Rgb.Rgb(0x66, 0x33, 0x99)
        },
        {
            "Red",
            new Rgb.Rgb(0xFF, 0x00, 0x00)
        },
        {
            "RosyBrown",
            new Rgb.Rgb(0xBC, 0x8F, 0x8F)
        },
        {
            "RoyalBlue",
            new Rgb.Rgb(0x41, 0x69, 0xE1)
        },
        {
            "SaddleBrown",
            new Rgb.Rgb(0x8B, 0x45, 0x13)
        },
        {
            "Salmon",
            new Rgb.Rgb(0xFA, 0x80, 0x72)
        },
        {
            "SandyBrown",
            new Rgb.Rgb(0xF4, 0xA4, 0x60)
        },
        {
            "SeaGreen",
            new Rgb.Rgb(0x2E, 0x8B, 0x57)
        },
        {
            "SeaShell",
            new Rgb.Rgb(0xFF, 0xF5, 0xEE)
        },
        {
            "Sienna",
            new Rgb.Rgb(0xA0, 0x52, 0x2D)
        },
        {
            "Silver",
            new Rgb.Rgb(0xC0, 0xC0, 0xC0)
        },
        {
            "SkyBlue",
            new Rgb.Rgb(0x87, 0xCE, 0xEB)
        },
        {
            "SlateBlue",
            new Rgb.Rgb(0x6A, 0x5A, 0xCD)
        },
        {
            "SlateGray",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "SlateGrey",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "Snow",
            new Rgb.Rgb(0xFF, 0xFA, 0xFA)
        },
        {
            "SpringGreen",
            new Rgb.Rgb(0x00, 0xFF, 0x7F)
        },
        {
            "SteelBlue",
            new Rgb.Rgb(0x46, 0x82, 0xB4)
        },
        {
            "Tan",
            new Rgb.Rgb(0xD2, 0xB4, 0x8C)
        },
        {
            "Teal",
            new Rgb.Rgb(0x00, 0x80, 0x80)
        },
        {
            "Thistle",
            new Rgb.Rgb(0xD8, 0xBF, 0xD8)
        },
        {
            "Tomato",
            new Rgb.Rgb(0xFF, 0x63, 0x47)
        },
        {
            "Turquoise",
            new Rgb.Rgb(0x40, 0xE0, 0xD0)
        },
        {
            "Violet",
            new Rgb.Rgb(0xEE, 0x82, 0xEE)
        },
        {
            "Wheat",
            new Rgb.Rgb(0xF5, 0xDE, 0xB3)
        },
        {
            "White",
            new Rgb.Rgb(0xFF, 0xFF, 0xFF)
        },
        {
            "WhiteSmoke",
            new Rgb.Rgb(0xF5, 0xF5, 0xF5)
        },
        {
            "Yellow",
            new Rgb.Rgb(0xFF, 0xFF, 0x00)
        },
        {
            "YellowGreen",
            new Rgb.Rgb(0x9A, 0xCD, 0x32)
        }
    };

    /// <summary>
    /// Represents all CSS colors (but lowercase) and their RGB values
    /// </summary>
    public static readonly Dictionary<string, Rgb.Rgb> LowerCaseCssToRgbColors = new()
    {
        {
            "aliceblue",
            new Rgb.Rgb(0xF0, 0xF8, 0xFF)
        },
        {
            "antiquewhite",
            new Rgb.Rgb(0xFA, 0xEB, 0xD7)
        },
        {
            "aqua",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "aquamarine",
            new Rgb.Rgb(0x7F, 0xFF, 0xD4)
        },
        {
            "azure",
            new Rgb.Rgb(0xF0, 0xFF, 0xFF)
        },
        {
            "beige",
            new Rgb.Rgb(0xF5, 0xF5, 0xDC)
        },
        {
            "bisque",
            new Rgb.Rgb(0xFF, 0xE4, 0xC4)
        },
        {
            "black",
            new Rgb.Rgb(0x00, 0x00, 0x00)
        },
        {
            "blanchedalmond",
            new Rgb.Rgb(0xFF, 0xEB, 0xCD)
        },
        {
            "blue",
            new Rgb.Rgb(0x00, 0x00, 0xFF)
        },
        {
            "blueviolet",
            new Rgb.Rgb(0x8A, 0x2B, 0xE2)
        },
        {
            "brown",
            new Rgb.Rgb(0xA5, 0x2A, 0x2A)
        },
        {
            "burlywood",
            new Rgb.Rgb(0xDE, 0xB8, 0x87)
        },
        {
            "cadetblue",
            new Rgb.Rgb(0x5F, 0x9E, 0xA0)
        },
        {
            "chartreuse",
            new Rgb.Rgb(0x7F, 0xFF, 0x00)
        },
        {
            "chocolate",
            new Rgb.Rgb(0xD2, 0x69, 0x1E)
        },
        {
            "coral",
            new Rgb.Rgb(0xFF, 0x7F, 0x50)
        },
        {
            "cornflowerblue",
            new Rgb.Rgb(0x64, 0x95, 0xED)
        },
        {
            "cornsilk",
            new Rgb.Rgb(0xFF, 0xF8, 0xDC)
        },
        {
            "crimson",
            new Rgb.Rgb(0xDC, 0x14, 0x3C)
        },
        {
            "cyan",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "darkblue",
            new Rgb.Rgb(0x00, 0x00, 0x8B)
        },
        {
            "darkcyan",
            new Rgb.Rgb(0x00, 0x8B, 0x8B)
        },
        {
            "darkgoldenrod",
            new Rgb.Rgb(0xB8, 0x86, 0x0B)
        },
        {
            "darkgray",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "darkgrey",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "darkgreen",
            new Rgb.Rgb(0x00, 0x64, 0x00)
        },
        {
            "darkkhaki",
            new Rgb.Rgb(0xBD, 0xB7, 0x6B)
        },
        {
            "darkmagenta",
            new Rgb.Rgb(0x8B, 0x00, 0x8B)
        },
        {
            "darkolivegreen",
            new Rgb.Rgb(0x55, 0x6B, 0x2F)
        },
        {
            "darkorange",
            new Rgb.Rgb(0xFF, 0x8C, 0x00)
        },
        {
            "darkorchid",
            new Rgb.Rgb(0x99, 0x32, 0xCC)
        },
        {
            "darkred",
            new Rgb.Rgb(0x8B, 0x00, 0x00)
        },
        {
            "darksalmon",
            new Rgb.Rgb(0xE9, 0x96, 0x7A)
        },
        {
            "darkseagreen",
            new Rgb.Rgb(0x8F, 0xBC, 0x8F)
        },
        {
            "darkslateblue",
            new Rgb.Rgb(0x48, 0x3D, 0x8B)
        },
        {
            "darkslategray",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "darkslategrey",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "darkturquoise",
            new Rgb.Rgb(0x00, 0xCE, 0xD1)
        },
        {
            "darkviolet",
            new Rgb.Rgb(0x94, 0x00, 0xD3)
        },
        {
            "deeppink",
            new Rgb.Rgb(0xFF, 0x14, 0x93)
        },
        {
            "deepskyblue",
            new Rgb.Rgb(0x00, 0xBF, 0xFF)
        },
        {
            "dimgray",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "dimgrey",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "dodgerblue",
            new Rgb.Rgb(0x1E, 0x90, 0xFF)
        },
        {
            "firebrick",
            new Rgb.Rgb(0xB2, 0x22, 0x22)
        },
        {
            "floralwhite",
            new Rgb.Rgb(0xFF, 0xFA, 0xF0)
        },
        {
            "forestgreen",
            new Rgb.Rgb(0x22, 0x8B, 0x22)
        },
        {
            "fuchsia",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "gainsboro",
            new Rgb.Rgb(0xDC, 0xDC, 0xDC)
        },
        {
            "ghostwhite",
            new Rgb.Rgb(0xF8, 0xF8, 0xFF)
        },
        {
            "gold",
            new Rgb.Rgb(0xFF, 0xD7, 0x00)
        },
        {
            "goldenrod",
            new Rgb.Rgb(0xDA, 0xA5, 0x20)
        },
        {
            "gray",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "grey",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "green",
            new Rgb.Rgb(0x00, 0x80, 0x00)
        },
        {
            "greenyellow",
            new Rgb.Rgb(0xAD, 0xFF, 0x2F)
        },
        {
            "honeydew",
            new Rgb.Rgb(0xF0, 0xFF, 0xF0)
        },
        {
            "hotpink",
            new Rgb.Rgb(0xFF, 0x69, 0xB4)
        },
        {
            "indianred",
            new Rgb.Rgb(0xCD, 0x5C, 0x5C)
        },
        {
            "indigo",
            new Rgb.Rgb(0x4B, 0x00, 0x82)
        },
        {
            "ivory",
            new Rgb.Rgb(0xFF, 0xFF, 0xF0)
        },
        {
            "khaki",
            new Rgb.Rgb(0xF0, 0xE6, 0x8C)
        },
        {
            "lavender",
            new Rgb.Rgb(0xE6, 0xE6, 0xFA)
        },
        {
            "lavenderblush",
            new Rgb.Rgb(0xFF, 0xF0, 0xF5)
        },
        {
            "lawngreen",
            new Rgb.Rgb(0x7C, 0xFC, 0x00)
        },
        {
            "lemonchiffon",
            new Rgb.Rgb(0xFF, 0xFA, 0xCD)
        },
        {
            "lightblue",
            new Rgb.Rgb(0xAD, 0xD8, 0xE6)
        },
        {
            "lightcoral",
            new Rgb.Rgb(0xF0, 0x80, 0x80)
        },
        {
            "lightcyan",
            new Rgb.Rgb(0xE0, 0xFF, 0xFF)
        },
        {
            "lightgoldenrodyellow",
            new Rgb.Rgb(0xFA, 0xFA, 0xD2)
        },
        {
            "lightgray",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "lightgrey",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "lightgreen",
            new Rgb.Rgb(0x90, 0xEE, 0x90)
        },
        {
            "lightpink",
            new Rgb.Rgb(0xFF, 0xB6, 0xC1)
        },
        {
            "lightsalmon",
            new Rgb.Rgb(0xFF, 0xA0, 0x7A)
        },
        {
            "lightseagreen",
            new Rgb.Rgb(0x20, 0xB2, 0xAA)
        },
        {
            "lightskyblue",
            new Rgb.Rgb(0x87, 0xCE, 0xFA)
        },
        {
            "lightslategray",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "lightslategrey",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "lightsteelblue",
            new Rgb.Rgb(0xB0, 0xC4, 0xDE)
        },
        {
            "lightyellow",
            new Rgb.Rgb(0xFF, 0xFF, 0xE0)
        },
        {
            "lime",
            new Rgb.Rgb(0x00, 0xFF, 0x00)
        },
        {
            "limegreen",
            new Rgb.Rgb(0x32, 0xCD, 0x32)
        },
        {
            "linen",
            new Rgb.Rgb(0xFA, 0xF0, 0xE6)
        },
        {
            "magenta",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "maroon",
            new Rgb.Rgb(0x80, 0x00, 0x00)
        },
        {
            "mediumaquamarine",
            new Rgb.Rgb(0x66, 0xCD, 0xAA)
        },
        {
            "mediumblue",
            new Rgb.Rgb(0x00, 0x00, 0xCD)
        },
        {
            "mediumorchid",
            new Rgb.Rgb(0xBA, 0x55, 0xD3)
        },
        {
            "mediumpurple",
            new Rgb.Rgb(0x93, 0x70, 0xDB)
        },
        {
            "mediumseagreen",
            new Rgb.Rgb(0x3C, 0xB3, 0x71)
        },
        {
            "mediumslateblue",
            new Rgb.Rgb(0x7B, 0x68, 0xEE)
        },
        {
            "mediumspringgreen",
            new Rgb.Rgb(0x00, 0xFA, 0x9A)
        },
        {
            "mediumturquoise",
            new Rgb.Rgb(0x48, 0xD1, 0xCC)
        },
        {
            "mediumvioletred",
            new Rgb.Rgb(0xC7, 0x15, 0x85)
        },
        {
            "midnightblue",
            new Rgb.Rgb(0x19, 0x19, 0x70)
        },
        {
            "mintcream",
            new Rgb.Rgb(0xF5, 0xFF, 0xFA)
        },
        {
            "mistyrose",
            new Rgb.Rgb(0xFF, 0xE4, 0xE1)
        },
        {
            "moccasin",
            new Rgb.Rgb(0xFF, 0xE4, 0xB5)
        },
        {
            "navajowhite",
            new Rgb.Rgb(0xFF, 0xDE, 0xAD)
        },
        {
            "navy",
            new Rgb.Rgb(0x00, 0x00, 0x80)
        },
        {
            "oldlace",
            new Rgb.Rgb(0xFD, 0xF5, 0xE6)
        },
        {
            "olive",
            new Rgb.Rgb(0x80, 0x80, 0x00)
        },
        {
            "olivedrab",
            new Rgb.Rgb(0x6B, 0x8E, 0x23)
        },
        {
            "orange",
            new Rgb.Rgb(0xFF, 0xA5, 0x00)
        },
        {
            "orangered",
            new Rgb.Rgb(0xFF, 0x45, 0x00)
        },
        {
            "orchid",
            new Rgb.Rgb(0xDA, 0x70, 0xD6)
        },
        {
            "palegoldenrod",
            new Rgb.Rgb(0xEE, 0xE8, 0xAA)
        },
        {
            "palegreen",
            new Rgb.Rgb(0x98, 0xFB, 0x98)
        },
        {
            "paleturquoise",
            new Rgb.Rgb(0xAF, 0xEE, 0xEE)
        },
        {
            "palevioletred",
            new Rgb.Rgb(0xDB, 0x70, 0x93)
        },
        {
            "papayawhip",
            new Rgb.Rgb(0xFF, 0xEF, 0xD5)
        },
        {
            "peachpuff",
            new Rgb.Rgb(0xFF, 0xDA, 0xB9)
        },
        {
            "peru",
            new Rgb.Rgb(0xCD, 0x85, 0x3F)
        },
        {
            "pink",
            new Rgb.Rgb(0xFF, 0xC0, 0xCB)
        },
        {
            "plum",
            new Rgb.Rgb(0xDD, 0xA0, 0xDD)
        },
        {
            "powderblue",
            new Rgb.Rgb(0xB0, 0xE0, 0xE6)
        },
        {
            "purple",
            new Rgb.Rgb(0x80, 0x00, 0x80)
        },
        {
            "rebeccapurple",
            new Rgb.Rgb(0x66, 0x33, 0x99)
        },
        {
            "red",
            new Rgb.Rgb(0xFF, 0x00, 0x00)
        },
        {
            "rosybrown",
            new Rgb.Rgb(0xBC, 0x8F, 0x8F)
        },
        {
            "royalblue",
            new Rgb.Rgb(0x41, 0x69, 0xE1)
        },
        {
            "saddlebrown",
            new Rgb.Rgb(0x8B, 0x45, 0x13)
        },
        {
            "salmon",
            new Rgb.Rgb(0xFA, 0x80, 0x72)
        },
        {
            "sandybrown",
            new Rgb.Rgb(0xF4, 0xA4, 0x60)
        },
        {
            "seagreen",
            new Rgb.Rgb(0x2E, 0x8B, 0x57)
        },
        {
            "seashell",
            new Rgb.Rgb(0xFF, 0xF5, 0xEE)
        },
        {
            "sienna",
            new Rgb.Rgb(0xA0, 0x52, 0x2D)
        },
        {
            "silver",
            new Rgb.Rgb(0xC0, 0xC0, 0xC0)
        },
        {
            "skyblue",
            new Rgb.Rgb(0x87, 0xCE, 0xEB)
        },
        {
            "slateblue",
            new Rgb.Rgb(0x6A, 0x5A, 0xCD)
        },
        {
            "slategray",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "slategrey",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "snow",
            new Rgb.Rgb(0xFF, 0xFA, 0xFA)
        },
        {
            "springgreen",
            new Rgb.Rgb(0x00, 0xFF, 0x7F)
        },
        {
            "steelblue",
            new Rgb.Rgb(0x46, 0x82, 0xB4)
        },
        {
            "tan",
            new Rgb.Rgb(0xD2, 0xB4, 0x8C)
        },
        {
            "teal",
            new Rgb.Rgb(0x00, 0x80, 0x80)
        },
        {
            "thistle",
            new Rgb.Rgb(0xD8, 0xBF, 0xD8)
        },
        {
            "tomato",
            new Rgb.Rgb(0xFF, 0x63, 0x47)
        },
        {
            "turquoise",
            new Rgb.Rgb(0x40, 0xE0, 0xD0)
        },
        {
            "violet",
            new Rgb.Rgb(0xEE, 0x82, 0xEE)
        },
        {
            "wheat",
            new Rgb.Rgb(0xF5, 0xDE, 0xB3)
        },
        {
            "white",
            new Rgb.Rgb(0xFF, 0xFF, 0xFF)
        },
        {
            "whitesmoke",
            new Rgb.Rgb(0xF5, 0xF5, 0xF5)
        },
        {
            "yellow",
            new Rgb.Rgb(0xFF, 0xFF, 0x00)
        },
        {
            "yellowgreen",
            new Rgb.Rgb(0x9A, 0xCD, 0x32)
        }
    };

    /// <summary>
    /// Represents all CSS colors (but uppercase) and their RGB values
    /// </summary>
    public static readonly Dictionary<string, Rgb.Rgb> UpperCaseCssToRgbColors = new()
    {
        {
            "ALICEBLUE",
            new Rgb.Rgb(0xF0, 0xF8, 0xFF)
        },
        {
            "ANTIQUEWHITE",
            new Rgb.Rgb(0xFA, 0xEB, 0xD7)
        },
        {
            "AQUA",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "AQUAMARINE",
            new Rgb.Rgb(0x7F, 0xFF, 0xD4)
        },
        {
            "AZURE",
            new Rgb.Rgb(0xF0, 0xFF, 0xFF)
        },
        {
            "BEIGE",
            new Rgb.Rgb(0xF5, 0xF5, 0xDC)
        },
        {
            "BISQUE",
            new Rgb.Rgb(0xFF, 0xE4, 0xC4)
        },
        {
            "BLACK",
            new Rgb.Rgb(0x00, 0x00, 0x00)
        },
        {
            "BLANCHEDALMOND",
            new Rgb.Rgb(0xFF, 0xEB, 0xCD)
        },
        {
            "BLUE",
            new Rgb.Rgb(0x00, 0x00, 0xFF)
        },
        {
            "BLUEVIOLET",
            new Rgb.Rgb(0x8A, 0x2B, 0xE2)
        },
        {
            "BROWN",
            new Rgb.Rgb(0xA5, 0x2A, 0x2A)
        },
        {
            "BURLYWOOD",
            new Rgb.Rgb(0xDE, 0xB8, 0x87)
        },
        {
            "CADETBLUE",
            new Rgb.Rgb(0x5F, 0x9E, 0xA0)
        },
        {
            "CHARTREUSE",
            new Rgb.Rgb(0x7F, 0xFF, 0x00)
        },
        {
            "CHOCOLATE",
            new Rgb.Rgb(0xD2, 0x69, 0x1E)
        },
        {
            "CORAL",
            new Rgb.Rgb(0xFF, 0x7F, 0x50)
        },
        {
            "CORNFLOWERBLUE",
            new Rgb.Rgb(0x64, 0x95, 0xED)
        },
        {
            "CORNSILK",
            new Rgb.Rgb(0xFF, 0xF8, 0xDC)
        },
        {
            "CRIMSON",
            new Rgb.Rgb(0xDC, 0x14, 0x3C)
        },
        {
            "CYAN",
            new Rgb.Rgb(0x00, 0xFF, 0xFF)
        },
        {
            "DARKBLUE",
            new Rgb.Rgb(0x00, 0x00, 0x8B)
        },
        {
            "DARKCYAN",
            new Rgb.Rgb(0x00, 0x8B, 0x8B)
        },
        {
            "DARKGOLDENROD",
            new Rgb.Rgb(0xB8, 0x86, 0x0B)
        },
        {
            "DARKGRAY",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "DARKGREY",
            new Rgb.Rgb(0xA9, 0xA9, 0xA9)
        },
        {
            "DARKGREEN",
            new Rgb.Rgb(0x00, 0x64, 0x00)
        },
        {
            "DARKKHAKI",
            new Rgb.Rgb(0xBD, 0xB7, 0x6B)
        },
        {
            "DARKMAGENTA",
            new Rgb.Rgb(0x8B, 0x00, 0x8B)
        },
        {
            "DARKOLIVEGREEN",
            new Rgb.Rgb(0x55, 0x6B, 0x2F)
        },
        {
            "DARKORANGE",
            new Rgb.Rgb(0xFF, 0x8C, 0x00)
        },
        {
            "DARKORCHID",
            new Rgb.Rgb(0x99, 0x32, 0xCC)
        },
        {
            "DARKRED",
            new Rgb.Rgb(0x8B, 0x00, 0x00)
        },
        {
            "DARKSALMON",
            new Rgb.Rgb(0xE9, 0x96, 0x7A)
        },
        {
            "DARKSEAGREEN",
            new Rgb.Rgb(0x8F, 0xBC, 0x8F)
        },
        {
            "DARKSLATEBLUE",
            new Rgb.Rgb(0x48, 0x3D, 0x8B)
        },
        {
            "DARKSLATEGRAY",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "DARKSLATEGREY",
            new Rgb.Rgb(0x2F, 0x4F, 0x4F)
        },
        {
            "DARKTURQUOISE",
            new Rgb.Rgb(0x00, 0xCE, 0xD1)
        },
        {
            "DARKVIOLET",
            new Rgb.Rgb(0x94, 0x00, 0xD3)
        },
        {
            "DEEPPINK",
            new Rgb.Rgb(0xFF, 0x14, 0x93)
        },
        {
            "DEEPSKYBLUE",
            new Rgb.Rgb(0x00, 0xBF, 0xFF)
        },
        {
            "DIMGRAY",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "DIMGREY",
            new Rgb.Rgb(0x69, 0x69, 0x69)
        },
        {
            "DODGERBLUE",
            new Rgb.Rgb(0x1E, 0x90, 0xFF)
        },
        {
            "FIREBRICK",
            new Rgb.Rgb(0xB2, 0x22, 0x22)
        },
        {
            "FLORALWHITE",
            new Rgb.Rgb(0xFF, 0xFA, 0xF0)
        },
        {
            "FORESTGREEN",
            new Rgb.Rgb(0x22, 0x8B, 0x22)
        },
        {
            "FUCHSIA",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "GAINSBORO",
            new Rgb.Rgb(0xDC, 0xDC, 0xDC)
        },
        {
            "GHOSTWHITE",
            new Rgb.Rgb(0xF8, 0xF8, 0xFF)
        },
        {
            "GOLD",
            new Rgb.Rgb(0xFF, 0xD7, 0x00)
        },
        {
            "GOLDENROD",
            new Rgb.Rgb(0xDA, 0xA5, 0x20)
        },
        {
            "GRAY",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "GREY",
            new Rgb.Rgb(0x80, 0x80, 0x80)
        },
        {
            "GREEN",
            new Rgb.Rgb(0x00, 0x80, 0x00)
        },
        {
            "GREENYELLOW",
            new Rgb.Rgb(0xAD, 0xFF, 0x2F)
        },
        {
            "HONEYDEW",
            new Rgb.Rgb(0xF0, 0xFF, 0xF0)
        },
        {
            "HOTPINK",
            new Rgb.Rgb(0xFF, 0x69, 0xB4)
        },
        {
            "INDIANRED",
            new Rgb.Rgb(0xCD, 0x5C, 0x5C)
        },
        {
            "INDIGO",
            new Rgb.Rgb(0x4B, 0x00, 0x82)
        },
        {
            "IVORY",
            new Rgb.Rgb(0xFF, 0xFF, 0xF0)
        },
        {
            "KHAKI",
            new Rgb.Rgb(0xF0, 0xE6, 0x8C)
        },
        {
            "LAVENDER",
            new Rgb.Rgb(0xE6, 0xE6, 0xFA)
        },
        {
            "LAVENDERBLUSH",
            new Rgb.Rgb(0xFF, 0xF0, 0xF5)
        },
        {
            "LAWNGREEN",
            new Rgb.Rgb(0x7C, 0xFC, 0x00)
        },
        {
            "LEMONCHIFFON",
            new Rgb.Rgb(0xFF, 0xFA, 0xCD)
        },
        {
            "LIGHTBLUE",
            new Rgb.Rgb(0xAD, 0xD8, 0xE6)
        },
        {
            "LIGHTCORAL",
            new Rgb.Rgb(0xF0, 0x80, 0x80)
        },
        {
            "LIGHTCYAN",
            new Rgb.Rgb(0xE0, 0xFF, 0xFF)
        },
        {
            "LIGHTGOLDENRODYELLOW",
            new Rgb.Rgb(0xFA, 0xFA, 0xD2)
        },
        {
            "LIGHTGRAY",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "LIGHTGREY",
            new Rgb.Rgb(0xD3, 0xD3, 0xD3)
        },
        {
            "LIGHTGREEN",
            new Rgb.Rgb(0x90, 0xEE, 0x90)
        },
        {
            "LIGHTPINK",
            new Rgb.Rgb(0xFF, 0xB6, 0xC1)
        },
        {
            "LIGHTSALMON",
            new Rgb.Rgb(0xFF, 0xA0, 0x7A)
        },
        {
            "LIGHTSEAGREEN",
            new Rgb.Rgb(0x20, 0xB2, 0xAA)
        },
        {
            "LIGHTSKYBLUE",
            new Rgb.Rgb(0x87, 0xCE, 0xFA)
        },
        {
            "LIGHTSLATEGRAY",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "LIGHTSLATEGREY",
            new Rgb.Rgb(0x77, 0x88, 0x99)
        },
        {
            "LIGHTSTEELBLUE",
            new Rgb.Rgb(0xB0, 0xC4, 0xDE)
        },
        {
            "LIGHTYELLOW",
            new Rgb.Rgb(0xFF, 0xFF, 0xE0)
        },
        {
            "LIME",
            new Rgb.Rgb(0x00, 0xFF, 0x00)
        },
        {
            "LIMEGREEN",
            new Rgb.Rgb(0x32, 0xCD, 0x32)
        },
        {
            "LINEN",
            new Rgb.Rgb(0xFA, 0xF0, 0xE6)
        },
        {
            "MAGENTA",
            new Rgb.Rgb(0xFF, 0x00, 0xFF)
        },
        {
            "MAROON",
            new Rgb.Rgb(0x80, 0x00, 0x00)
        },
        {
            "MEDIUMAQUAMARINE",
            new Rgb.Rgb(0x66, 0xCD, 0xAA)
        },
        {
            "MEDIUMBLUE",
            new Rgb.Rgb(0x00, 0x00, 0xCD)
        },
        {
            "MEDIUMORCHID",
            new Rgb.Rgb(0xBA, 0x55, 0xD3)
        },
        {
            "MEDIUMPURPLE",
            new Rgb.Rgb(0x93, 0x70, 0xDB)
        },
        {
            "MEDIUMSEAGREEN",
            new Rgb.Rgb(0x3C, 0xB3, 0x71)
        },
        {
            "MEDIUMSLATEBLUE",
            new Rgb.Rgb(0x7B, 0x68, 0xEE)
        },
        {
            "MEDIUMSPRINGGREEN",
            new Rgb.Rgb(0x00, 0xFA, 0x9A)
        },
        {
            "MEDIUMTURQUOISE",
            new Rgb.Rgb(0x48, 0xD1, 0xCC)
        },
        {
            "MEDIUMVIOLETRED",
            new Rgb.Rgb(0xC7, 0x15, 0x85)
        },
        {
            "MIDNIGHTBLUE",
            new Rgb.Rgb(0x19, 0x19, 0x70)
        },
        {
            "MINTCREAM",
            new Rgb.Rgb(0xF5, 0xFF, 0xFA)
        },
        {
            "MISTYROSE",
            new Rgb.Rgb(0xFF, 0xE4, 0xE1)
        },
        {
            "MOCCASIN",
            new Rgb.Rgb(0xFF, 0xE4, 0xB5)
        },
        {
            "NAVAJOWHITE",
            new Rgb.Rgb(0xFF, 0xDE, 0xAD)
        },
        {
            "NAVY",
            new Rgb.Rgb(0x00, 0x00, 0x80)
        },
        {
            "OLDLACE",
            new Rgb.Rgb(0xFD, 0xF5, 0xE6)
        },
        {
            "OLIVE",
            new Rgb.Rgb(0x80, 0x80, 0x00)
        },
        {
            "OLIVEDRAB",
            new Rgb.Rgb(0x6B, 0x8E, 0x23)
        },
        {
            "ORANGE",
            new Rgb.Rgb(0xFF, 0xA5, 0x00)
        },
        {
            "ORANGERED",
            new Rgb.Rgb(0xFF, 0x45, 0x00)
        },
        {
            "ORCHID",
            new Rgb.Rgb(0xDA, 0x70, 0xD6)
        },
        {
            "PALEGOLDENROD",
            new Rgb.Rgb(0xEE, 0xE8, 0xAA)
        },
        {
            "PALEGREEN",
            new Rgb.Rgb(0x98, 0xFB, 0x98)
        },
        {
            "PALETURQUOISE",
            new Rgb.Rgb(0xAF, 0xEE, 0xEE)
        },
        {
            "PALEVIOLETRED",
            new Rgb.Rgb(0xDB, 0x70, 0x93)
        },
        {
            "PAPAYAWHIP",
            new Rgb.Rgb(0xFF, 0xEF, 0xD5)
        },
        {
            "PEACHPUFF",
            new Rgb.Rgb(0xFF, 0xDA, 0xB9)
        },
        {
            "PERU",
            new Rgb.Rgb(0xCD, 0x85, 0x3F)
        },
        {
            "PINK",
            new Rgb.Rgb(0xFF, 0xC0, 0xCB)
        },
        {
            "PLUM",
            new Rgb.Rgb(0xDD, 0xA0, 0xDD)
        },
        {
            "POWDERBLUE",
            new Rgb.Rgb(0xB0, 0xE0, 0xE6)
        },
        {
            "PURPLE",
            new Rgb.Rgb(0x80, 0x00, 0x80)
        },
        {
            "REBECCAPURPLE",
            new Rgb.Rgb(0x66, 0x33, 0x99)
        },
        {
            "RED",
            new Rgb.Rgb(0xFF, 0x00, 0x00)
        },
        {
            "ROSYBROWN",
            new Rgb.Rgb(0xBC, 0x8F, 0x8F)
        },
        {
            "ROYALBLUE",
            new Rgb.Rgb(0x41, 0x69, 0xE1)
        },
        {
            "SADDLEBROWN",
            new Rgb.Rgb(0x8B, 0x45, 0x13)
        },
        {
            "SALMON",
            new Rgb.Rgb(0xFA, 0x80, 0x72)
        },
        {
            "SANDYBROWN",
            new Rgb.Rgb(0xF4, 0xA4, 0x60)
        },
        {
            "SEAGREEN",
            new Rgb.Rgb(0x2E, 0x8B, 0x57)
        },
        {
            "SEASHELL",
            new Rgb.Rgb(0xFF, 0xF5, 0xEE)
        },
        {
            "SIENNA",
            new Rgb.Rgb(0xA0, 0x52, 0x2D)
        },
        {
            "SILVER",
            new Rgb.Rgb(0xC0, 0xC0, 0xC0)
        },
        {
            "SKYBLUE",
            new Rgb.Rgb(0x87, 0xCE, 0xEB)
        },
        {
            "SLATEBLUE",
            new Rgb.Rgb(0x6A, 0x5A, 0xCD)
        },
        {
            "SLATEGRAY",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "SLATEGREY",
            new Rgb.Rgb(0x70, 0x80, 0x90)
        },
        {
            "SNOW",
            new Rgb.Rgb(0xFF, 0xFA, 0xFA)
        },
        {
            "SPRINGGREEN",
            new Rgb.Rgb(0x00, 0xFF, 0x7F)
        },
        {
            "STEELBLUE",
            new Rgb.Rgb(0x46, 0x82, 0xB4)
        },
        {
            "TAN",
            new Rgb.Rgb(0xD2, 0xB4, 0x8C)
        },
        {
            "TEAL",
            new Rgb.Rgb(0x00, 0x80, 0x80)
        },
        {
            "THISTLE",
            new Rgb.Rgb(0xD8, 0xBF, 0xD8)
        },
        {
            "TOMATO",
            new Rgb.Rgb(0xFF, 0x63, 0x47)
        },
        {
            "TURQUOISE",
            new Rgb.Rgb(0x40, 0xE0, 0xD0)
        },
        {
            "VIOLET",
            new Rgb.Rgb(0xEE, 0x82, 0xEE)
        },
        {
            "WHEAT",
            new Rgb.Rgb(0xF5, 0xDE, 0xB3)
        },
        {
            "WHITE",
            new Rgb.Rgb(0xFF, 0xFF, 0xFF)
        },
        {
            "WHITESMOKE",
            new Rgb.Rgb(0xF5, 0xF5, 0xF5)
        },
        {
            "YELLOW",
            new Rgb.Rgb(0xFF, 0xFF, 0x00)
        },
        {
            "YELLOWGREEN",
            new Rgb.Rgb(0x9A, 0xCD, 0x32)
        }
    };

    /// <summary>
    /// Represents all CSS colors and their hex values
    /// </summary>
    public static readonly Dictionary<string, string> CssToHexColors = new()
    {
        {
            "AliceBlue",
            "#F0F8FF"
        },
        {
            "AntiqueWhite",
            "#FAEBD7"
        },
        {
            "Aqua",
            "#00FFFF"
        },
        {
            "Aquamarine",
            "#7FFFD4"
        },
        {
            "Azure",
            "#F0FFFF"
        },
        {
            "Beige",
            "#F5F5DC"
        },
        {
            "Bisque",
            "#FFE4C4"
        },
        {
            "Black",
            "#000000"
        },
        {
            "BlanchedAlmond",
            "#FFEBCD"
        },
        {
            "Blue",
            "#0000FF"
        },
        {
            "BlueViolet",
            "#8A2BE2"
        },
        {
            "Brown",
            "#A52A2A"
        },
        {
            "BurlyWood",
            "#DEB887"
        },
        {
            "CadetBlue",
            "#5F9EA0"
        },
        {
            "Chartreuse",
            "#7FFF00"
        },
        {
            "Chocolate",
            "#D2691E"
        },
        {
            "Coral",
            "#FF7F50"
        },
        {
            "CornflowerBlue",
            "#6495ED"
        },
        {
            "Cornsilk",
            "#FFF8DC"
        },
        {
            "Crimson",
            "#DC143C"
        },
        {
            "Cyan",
            "#00FFFF"
        },
        {
            "DarkBlue",
            "#00008B"
        },
        {
            "DarkCyan",
            "#008B8B"
        },
        {
            "DarkGoldenRod",
            "#B8860B"
        },
        {
            "DarkGray",
            "#A9A9A9"
        },
        {
            "DarkGrey",
            "#A9A9A9"
        },
        {
            "DarkGreen",
            "#006400"
        },
        {
            "DarkKhaki",
            "#BDB76B"
        },
        {
            "DarkMagenta",
            "#8B008B"
        },
        {
            "DarkOliveGreen",
            "#556B2F"
        },
        {
            "DarkOrange",
            "#FF8C00"
        },
        {
            "DarkOrchid",
            "#9932CC"
        },
        {
            "DarkRed",
            "#8B0000"
        },
        {
            "DarkSalmon",
            "#E9967A"
        },
        {
            "DarkSeaGreen",
            "#8FBC8F"
        },
        {
            "DarkSlateBlue",
            "#483D8B"
        },
        {
            "DarkSlateGray",
            "#2F4F4F"
        },
        {
            "DarkSlateGrey",
            "#2F4F4F"
        },
        {
            "DarkTurquoise",
            "#00CED1"
        },
        {
            "DarkViolet",
            "#9400D3"
        },
        {
            "DeepPink",
            "#FF1493"
        },
        {
            "DeepSkyBlue",
            "#00BFFF"
        },
        {
            "DimGray",
            "#696969"
        },
        {
            "DimGrey",
            "#696969"
        },
        {
            "DodgerBlue",
            "#1E90FF"
        },
        {
            "FireBrick",
            "#B22222"
        },
        {
            "FloralWhite",
            "#FFFAF0"
        },
        {
            "ForestGreen",
            "#228B22"
        },
        {
            "Fuchsia",
            "#FF00FF"
        },
        {
            "Gainsboro",
            "#DCDCDC"
        },
        {
            "GhostWhite",
            "#F8F8FF"
        },
        {
            "Gold",
            "#FFD700"
        },
        {
            "GoldenRod",
            "#DAA520"
        },
        {
            "Gray",
            "#808080"
        },
        {
            "Grey",
            "#808080"
        },
        {
            "Green",
            "#008000"
        },
        {
            "GreenYellow",
            "#ADFF2F"
        },
        {
            "HoneyDew",
            "#F0FFF0"
        },
        {
            "HotPink",
            "#FF69B4"
        },
        {
            "IndianRed",
            "#CD5C5C"
        },
        {
            "Indigo",
            "#4B0082"
        },
        {
            "Ivory",
            "#FFFFF0"
        },
        {
            "Khaki",
            "#F0E68C"
        },
        {
            "Lavender",
            "#E6E6FA"
        },
        {
            "LavenderBlush",
            "#FFF0F5"
        },
        {
            "LawnGreen",
            "#7CFC00"
        },
        {
            "LemonChiffon",
            "#FFFACD"
        },
        {
            "LightBlue",
            "#ADD8E6"
        },
        {
            "LightCoral",
            "#F08080"
        },
        {
            "LightCyan",
            "#E0FFFF"
        },
        {
            "LightGoldenRodYellow",
            "#FAFAD2"
        },
        {
            "LightGray",
            "#D3D3D3"
        },
        {
            "LightGrey",
            "#D3D3D3"
        },
        {
            "LightGreen",
            "#90EE90"
        },
        {
            "LightPink",
            "#FFB6C1"
        },
        {
            "LightSalmon",
            "#FFA07A"
        },
        {
            "LightSeaGreen",
            "#20B2AA"
        },
        {
            "LightSkyBlue",
            "#87CEFA"
        },
        {
            "LightSlateGray",
            "#778899"
        },
        {
            "LightSlateGrey",
            "#778899"
        },
        {
            "LightSteelBlue",
            "#B0C4DE"
        },
        {
            "LightYellow",
            "#FFFFE0"
        },
        {
            "Lime",
            "#00FF00"
        },
        {
            "LimeGreen",
            "#32CD32"
        },
        {
            "Linen",
            "#FAF0E6"
        },
        {
            "Magenta",
            "#FF00FF"
        },
        {
            "Maroon",
            "#800000"
        },
        {
            "MediumAquaMarine",
            "#66CDAA"
        },
        {
            "MediumBlue",
            "#0000CD"
        },
        {
            "MediumOrchid",
            "#BA55D3"
        },
        {
            "MediumPurple",
            "#9370DB"
        },
        {
            "MediumSeaGreen",
            "#3CB371"
        },
        {
            "MediumSlateBlue",
            "#7B68EE"
        },
        {
            "MediumSpringGreen",
            "#00FA9A"
        },
        {
            "MediumTurquoise",
            "#48D1CC"
        },
        {
            "MediumVioletRed",
            "#C71585"
        },
        {
            "MidnightBlue",
            "#191970"
        },
        {
            "MintCream",
            "#F5FFFA"
        },
        {
            "MistyRose",
            "#FFE4E1"
        },
        {
            "Moccasin",
            "#FFE4B5"
        },
        {
            "NavajoWhite",
            "#FFDEAD"
        },
        {
            "Navy",
            "#000080"
        },
        {
            "OldLace",
            "#FDF5E6"
        },
        {
            "Olive",
            "#808000"
        },
        {
            "OliveDrab",
            "#6B8E23"
        },
        {
            "Orange",
            "#FFA500"
        },
        {
            "OrangeRed",
            "#FF4500"
        },
        {
            "Orchid",
            "#DA70D6"
        },
        {
            "PaleGoldenRod",
            "#EEE8AA"
        },
        {
            "PaleGreen",
            "#98FB98"
        },
        {
            "PaleTurquoise",
            "#AFEEEE"
        },
        {
            "PaleVioletRed",
            "#DB7093"
        },
        {
            "PapayaWhip",
            "#FFEFD5"
        },
        {
            "PeachPuff",
            "#FFDAB9"
        },
        {
            "Peru",
            "#CD853F"
        },
        {
            "Pink",
            "#FFC0CB"
        },
        {
            "Plum",
            "#DDA0DD"
        },
        {
            "PowderBlue",
            "#B0E0E6"
        },
        {
            "Purple",
            "#800080"
        },
        {
            "RebeccaPurple",
            "#663399"
        },
        {
            "Red",
            "#FF0000"
        },
        {
            "RosyBrown",
            "#BC8F8F"
        },
        {
            "RoyalBlue",
            "#4169E1"
        },
        {
            "SaddleBrown",
            "#8B4513"
        },
        {
            "Salmon",
            "#FA8072"
        },
        {
            "SandyBrown",
            "#F4A460"
        },
        {
            "SeaGreen",
            "#2E8B57"
        },
        {
            "SeaShell",
            "#FFF5EE"
        },
        {
            "Sienna",
            "#A0522D"
        },
        {
            "Silver",
            "#C0C0C0"
        },
        {
            "SkyBlue",
            "#87CEEB"
        },
        {
            "SlateBlue",
            "#6A5ACD"
        },
        {
            "SlateGray",
            "#708090"
        },
        {
            "SlateGrey",
            "#708090"
        },
        {
            "Snow",
            "#FFFAFA"
        },
        {
            "SpringGreen",
            "#00FF7F"
        },
        {
            "SteelBlue",
            "#4682B4"
        },
        {
            "Tan",
            "#D2B48C"
        },
        {
            "Teal",
            "#008080"
        },
        {
            "Thistle",
            "#D8BFD8"
        },
        {
            "Tomato",
            "#FF6347"
        },
        {
            "Turquoise",
            "#40E0D0"
        },
        {
            "Violet",
            "#EE82EE"
        },
        {
            "Wheat",
            "#F5DEB3"
        },
        {
            "White",
            "#FFFFFF"
        },
        {
            "WhiteSmoke",
            "#F5F5F5"
        },
        {
            "Yellow",
            "#FFFF00"
        },
        {
            "YellowGreen",
            "#9ACD32"
        }
    };

    /// <summary>
    /// Represents all CSS colors (but uppercase) and their hex values
    /// </summary>
    public static readonly Dictionary<string, string> UpperCaseCssToHexColors = new()
    {
        {
            "ALICEBLUE",
            "#F0F8FF"
        },
        {
            "ANTIQUEWHITE",
            "#FAEBD7"
        },
        {
            "AQUA",
            "#00FFFF"
        },
        {
            "AQUAMARINE",
            "#7FFFD4"
        },
        {
            "AZURE",
            "#F0FFFF"
        },
        {
            "BEIGE",
            "#F5F5DC"
        },
        {
            "BISQUE",
            "#FFE4C4"
        },
        {
            "BLACK",
            "#000000"
        },
        {
            "BLANCHEDALMOND",
            "#FFEBCD"
        },
        {
            "BLUE",
            "#0000FF"
        },
        {
            "BLUEVIOLET",
            "#8A2BE2"
        },
        {
            "BROWN",
            "#A52A2A"
        },
        {
            "BURLYWOOD",
            "#DEB887"
        },
        {
            "CADETBLUE",
            "#5F9EA0"
        },
        {
            "CHARTREUSE",
            "#7FFF00"
        },
        {
            "CHOCOLATE",
            "#D2691E"
        },
        {
            "CORAL",
            "#FF7F50"
        },
        {
            "CORNFLOWERBLUE",
            "#6495ED"
        },
        {
            "CORNSILK",
            "#FFF8DC"
        },
        {
            "CRIMSON",
            "#DC143C"
        },
        {
            "CYAN",
            "#00FFFF"
        },
        {
            "DARKBLUE",
            "#00008B"
        },
        {
            "DARKCYAN",
            "#008B8B"
        },
        {
            "DARKGOLDENROD",
            "#B8860B"
        },
        {
            "DARKGRAY",
            "#A9A9A9"
        },
        {
            "DARKGREY",
            "#A9A9A9"
        },
        {
            "DARKGREEN",
            "#006400"
        },
        {
            "DARKKHAKI",
            "#BDB76B"
        },
        {
            "DARKMAGENTA",
            "#8B008B"
        },
        {
            "DARKOLIVEGREEN",
            "#556B2F"
        },
        {
            "DARKORANGE",
            "#FF8C00"
        },
        {
            "DARKORCHID",
            "#9932CC"
        },
        {
            "DARKRED",
            "#8B0000"
        },
        {
            "DARKSALMON",
            "#E9967A"
        },
        {
            "DARKSEAGREEN",
            "#8FBC8F"
        },
        {
            "DARKSLATEBLUE",
            "#483D8B"
        },
        {
            "DARKSLATEGRAY",
            "#2F4F4F"
        },
        {
            "DARKSLATEGREY",
            "#2F4F4F"
        },
        {
            "DARKTURQUOISE",
            "#00CED1"
        },
        {
            "DARKVIOLET",
            "#9400D3"
        },
        {
            "DEEPPINK",
            "#FF1493"
        },
        {
            "DEEPSKYBLUE",
            "#00BFFF"
        },
        {
            "DIMGRAY",
            "#696969"
        },
        {
            "DIMGREY",
            "#696969"
        },
        {
            "DODGERBLUE",
            "#1E90FF"
        },
        {
            "FIREBRICK",
            "#B22222"
        },
        {
            "FLORALWHITE",
            "#FFFAF0"
        },
        {
            "FORESTGREEN",
            "#228B22"
        },
        {
            "FUCHSIA",
            "#FF00FF"
        },
        {
            "GAINSBORO",
            "#DCDCDC"
        },
        {
            "GHOSTWHITE",
            "#F8F8FF"
        },
        {
            "GOLD",
            "#FFD700"
        },
        {
            "GOLDENROD",
            "#DAA520"
        },
        {
            "GRAY",
            "#808080"
        },
        {
            "GREY",
            "#808080"
        },
        {
            "GREEN",
            "#008000"
        },
        {
            "GREENYELLOW",
            "#ADFF2F"
        },
        {
            "HONEYDEW",
            "#F0FFF0"
        },
        {
            "HOTPINK",
            "#FF69B4"
        },
        {
            "INDIANRED",
            "#CD5C5C"
        },
        {
            "INDIGO",
            "#4B0082"
        },
        {
            "IVORY",
            "#FFFFF0"
        },
        {
            "KHAKI",
            "#F0E68C"
        },
        {
            "LAVENDER",
            "#E6E6FA"
        },
        {
            "LAVENDERBLUSH",
            "#FFF0F5"
        },
        {
            "LAWNGREEN",
            "#7CFC00"
        },
        {
            "LEMONCHIFFON",
            "#FFFACD"
        },
        {
            "LIGHTBLUE",
            "#ADD8E6"
        },
        {
            "LIGHTCORAL",
            "#F08080"
        },
        {
            "LIGHTCYAN",
            "#E0FFFF"
        },
        {
            "LIGHTGOLDENRODYELLOW",
            "#FAFAD2"
        },
        {
            "LIGHTGRAY",
            "#D3D3D3"
        },
        {
            "LIGHTGREY",
            "#D3D3D3"
        },
        {
            "LIGHTGREEN",
            "#90EE90"
        },
        {
            "LIGHTPINK",
            "#FFB6C1"
        },
        {
            "LIGHTSALMON",
            "#FFA07A"
        },
        {
            "LIGHTSEAGREEN",
            "#20B2AA"
        },
        {
            "LIGHTSKYBLUE",
            "#87CEFA"
        },
        {
            "LIGHTSLATEGRAY",
            "#778899"
        },
        {
            "LIGHTSLATEGREY",
            "#778899"
        },
        {
            "LIGHTSTEELBLUE",
            "#B0C4DE"
        },
        {
            "LIGHTYELLOW",
            "#FFFFE0"
        },
        {
            "LIME",
            "#00FF00"
        },
        {
            "LIMEGREEN",
            "#32CD32"
        },
        {
            "LINEN",
            "#FAF0E6"
        },
        {
            "MAGENTA",
            "#FF00FF"
        },
        {
            "MAROON",
            "#800000"
        },
        {
            "MEDIUMAQUAMARINE",
            "#66CDAA"
        },
        {
            "MEDIUMBLUE",
            "#0000CD"
        },
        {
            "MEDIUMORCHID",
            "#BA55D3"
        },
        {
            "MEDIUMPURPLE",
            "#9370DB"
        },
        {
            "MEDIUMSEAGREEN",
            "#3CB371"
        },
        {
            "MEDIUMSLATEBLUE",
            "#7B68EE"
        },
        {
            "MEDIUMSPRINGGREEN",
            "#00FA9A"
        },
        {
            "MEDIUMTURQUOISE",
            "#48D1CC"
        },
        {
            "MEDIUMVIOLETRED",
            "#C71585"
        },
        {
            "MIDNIGHTBLUE",
            "#191970"
        },
        {
            "MINTCREAM",
            "#F5FFFA"
        },
        {
            "MISTYROSE",
            "#FFE4E1"
        },
        {
            "MOCCASIN",
            "#FFE4B5"
        },
        {
            "NAVAJOWHITE",
            "#FFDEAD"
        },
        {
            "NAVY",
            "#000080"
        },
        {
            "OLDLACE",
            "#FDF5E6"
        },
        {
            "OLIVE",
            "#808000"
        },
        {
            "OLIVEDRAB",
            "#6B8E23"
        },
        {
            "ORANGE",
            "#FFA500"
        },
        {
            "ORANGERED",
            "#FF4500"
        },
        {
            "ORCHID",
            "#DA70D6"
        },
        {
            "PALEGOLDENROD",
            "#EEE8AA"
        },
        {
            "PALEGREEN",
            "#98FB98"
        },
        {
            "PALETURQUOISE",
            "#AFEEEE"
        },
        {
            "PALEVIOLETRED",
            "#DB7093"
        },
        {
            "PAPAYAWHIP",
            "#FFEFD5"
        },
        {
            "PEACHPUFF",
            "#FFDAB9"
        },
        {
            "PERU",
            "#CD853F"
        },
        {
            "PINK",
            "#FFC0CB"
        },
        {
            "PLUM",
            "#DDA0DD"
        },
        {
            "POWDERBLUE",
            "#B0E0E6"
        },
        {
            "PURPLE",
            "#800080"
        },
        {
            "REBECCAPURPLE",
            "#663399"
        },
        {
            "RED",
            "#FF0000"
        },
        {
            "ROSYBROWN",
            "#BC8F8F"
        },
        {
            "ROYALBLUE",
            "#4169E1"
        },
        {
            "SADDLEBROWN",
            "#8B4513"
        },
        {
            "SALMON",
            "#FA8072"
        },
        {
            "SANDYBROWN",
            "#F4A460"
        },
        {
            "SEAGREEN",
            "#2E8B57"
        },
        {
            "SEASHELL",
            "#FFF5EE"
        },
        {
            "SIENNA",
            "#A0522D"
        },
        {
            "SILVER",
            "#C0C0C0"
        },
        {
            "SKYBLUE",
            "#87CEEB"
        },
        {
            "SLATEBLUE",
            "#6A5ACD"
        },
        {
            "SLATEGRAY",
            "#708090"
        },
        {
            "SLATEGREY",
            "#708090"
        },
        {
            "SNOW",
            "#FFFAFA"
        },
        {
            "SPRINGGREEN",
            "#00FF7F"
        },
        {
            "STEELBLUE",
            "#4682B4"
        },
        {
            "TAN",
            "#D2B48C"
        },
        {
            "TEAL",
            "#008080"
        },
        {
            "THISTLE",
            "#D8BFD8"
        },
        {
            "TOMATO",
            "#FF6347"
        },
        {
            "TURQUOISE",
            "#40E0D0"
        },
        {
            "VIOLET",
            "#EE82EE"
        },
        {
            "WHEAT",
            "#F5DEB3"
        },
        {
            "WHITE",
            "#FFFFFF"
        },
        {
            "WHITESMOKE",
            "#F5F5F5"
        },
        {
            "YELLOW",
            "#FFFF00"
        },
        {
            "YELLOWGREEN",
            "#9ACD32"
        }
    };

    /// <summary>
    /// Represents all CSS colors (but lowercase) and their hex values
    /// </summary>
    public static readonly Dictionary<string, string> LowerCaseCssToHexColors = new()
    {
        {
            "aliceblue",
            "#F0F8FF"
        },
        {
            "antiquewhite",
            "#FAEBD7"
        },
        {
            "aqua",
            "#00FFFF"
        },
        {
            "aquamarine",
            "#7FFFD4"
        },
        {
            "azure",
            "#F0FFFF"
        },
        {
            "beige",
            "#F5F5DC"
        },
        {
            "bisque",
            "#FFE4C4"
        },
        {
            "black",
            "#000000"
        },
        {
            "blanchedalmond",
            "#FFEBCD"
        },
        {
            "blue",
            "#0000FF"
        },
        {
            "blueviolet",
            "#8A2BE2"
        },
        {
            "brown",
            "#A52A2A"
        },
        {
            "burlywood",
            "#DEB887"
        },
        {
            "cadetblue",
            "#5F9EA0"
        },
        {
            "chartreuse",
            "#7FFF00"
        },
        {
            "chocolate",
            "#D2691E"
        },
        {
            "coral",
            "#FF7F50"
        },
        {
            "cornflowerblue",
            "#6495ED"
        },
        {
            "cornsilk",
            "#FFF8DC"
        },
        {
            "crimson",
            "#DC143C"
        },
        {
            "cyan",
            "#00FFFF"
        },
        {
            "darkblue",
            "#00008B"
        },
        {
            "darkcyan",
            "#008B8B"
        },
        {
            "darkgoldenrod",
            "#B8860B"
        },
        {
            "darkgray",
            "#A9A9A9"
        },
        {
            "darkgrey",
            "#A9A9A9"
        },
        {
            "darkgreen",
            "#006400"
        },
        {
            "darkkhaki",
            "#BDB76B"
        },
        {
            "darkmagenta",
            "#8B008B"
        },
        {
            "darkolivegreen",
            "#556B2F"
        },
        {
            "darkorange",
            "#FF8C00"
        },
        {
            "darkorchid",
            "#9932CC"
        },
        {
            "darkred",
            "#8B0000"
        },
        {
            "darksalmon",
            "#E9967A"
        },
        {
            "darkseagreen",
            "#8FBC8F"
        },
        {
            "darkslateblue",
            "#483D8B"
        },
        {
            "darkslategray",
            "#2F4F4F"
        },
        {
            "darkslategrey",
            "#2F4F4F"
        },
        {
            "darkturquoise",
            "#00CED1"
        },
        {
            "darkviolet",
            "#9400D3"
        },
        {
            "deeppink",
            "#FF1493"
        },
        {
            "deepskyblue",
            "#00BFFF"
        },
        {
            "dimgray",
            "#696969"
        },
        {
            "dimgrey",
            "#696969"
        },
        {
            "dodgerblue",
            "#1E90FF"
        },
        {
            "firebrick",
            "#B22222"
        },
        {
            "floralwhite",
            "#FFFAF0"
        },
        {
            "forestgreen",
            "#228B22"
        },
        {
            "fuchsia",
            "#FF00FF"
        },
        {
            "gainsboro",
            "#DCDCDC"
        },
        {
            "ghostwhite",
            "#F8F8FF"
        },
        {
            "gold",
            "#FFD700"
        },
        {
            "goldenrod",
            "#DAA520"
        },
        {
            "gray",
            "#808080"
        },
        {
            "grey",
            "#808080"
        },
        {
            "green",
            "#008000"
        },
        {
            "greenyellow",
            "#ADFF2F"
        },
        {
            "honeydew",
            "#F0FFF0"
        },
        {
            "hotpink",
            "#FF69B4"
        },
        {
            "indianred",
            "#CD5C5C"
        },
        {
            "indigo",
            "#4B0082"
        },
        {
            "ivory",
            "#FFFFF0"
        },
        {
            "khaki",
            "#F0E68C"
        },
        {
            "lavender",
            "#E6E6FA"
        },
        {
            "lavenderblush",
            "#FFF0F5"
        },
        {
            "lawngreen",
            "#7CFC00"
        },
        {
            "lemonchiffon",
            "#FFFACD"
        },
        {
            "lightblue",
            "#ADD8E6"
        },
        {
            "lightcoral",
            "#F08080"
        },
        {
            "lightcyan",
            "#E0FFFF"
        },
        {
            "lightgoldenrodyellow",
            "#FAFAD2"
        },
        {
            "lightgray",
            "#D3D3D3"
        },
        {
            "lightgrey",
            "#D3D3D3"
        },
        {
            "lightgreen",
            "#90EE90"
        },
        {
            "lightpink",
            "#FFB6C1"
        },
        {
            "lightsalmon",
            "#FFA07A"
        },
        {
            "lightseagreen",
            "#20B2AA"
        },
        {
            "lightskyblue",
            "#87CEFA"
        },
        {
            "lightslategray",
            "#778899"
        },
        {
            "lightslategrey",
            "#778899"
        },
        {
            "lightsteelblue",
            "#B0C4DE"
        },
        {
            "lightyellow",
            "#FFFFE0"
        },
        {
            "lime",
            "#00FF00"
        },
        {
            "limegreen",
            "#32CD32"
        },
        {
            "linen",
            "#FAF0E6"
        },
        {
            "magenta",
            "#FF00FF"
        },
        {
            "maroon",
            "#800000"
        },
        {
            "mediumaquamarine",
            "#66CDAA"
        },
        {
            "mediumblue",
            "#0000CD"
        },
        {
            "mediumorchid",
            "#BA55D3"
        },
        {
            "mediumpurple",
            "#9370DB"
        },
        {
            "mediumseagreen",
            "#3CB371"
        },
        {
            "mediumslateblue",
            "#7B68EE"
        },
        {
            "mediumspringgreen",
            "#00FA9A"
        },
        {
            "mediumturquoise",
            "#48D1CC"
        },
        {
            "mediumvioletred",
            "#C71585"
        },
        {
            "midnightblue",
            "#191970"
        },
        {
            "mintcream",
            "#F5FFFA"
        },
        {
            "mistyrose",
            "#FFE4E1"
        },
        {
            "moccasin",
            "#FFE4B5"
        },
        {
            "navajowhite",
            "#FFDEAD"
        },
        {
            "navy",
            "#000080"
        },
        {
            "oldlace",
            "#FDF5E6"
        },
        {
            "olive",
            "#808000"
        },
        {
            "olivedrab",
            "#6B8E23"
        },
        {
            "orange",
            "#FFA500"
        },
        {
            "orangered",
            "#FF4500"
        },
        {
            "orchid",
            "#DA70D6"
        },
        {
            "palegoldenrod",
            "#EEE8AA"
        },
        {
            "palegreen",
            "#98FB98"
        },
        {
            "paleturquoise",
            "#AFEEEE"
        },
        {
            "palevioletred",
            "#DB7093"
        },
        {
            "papayawhip",
            "#FFEFD5"
        },
        {
            "peachpuff",
            "#FFDAB9"
        },
        {
            "peru",
            "#CD853F"
        },
        {
            "pink",
            "#FFC0CB"
        },
        {
            "plum",
            "#DDA0DD"
        },
        {
            "powderblue",
            "#B0E0E6"
        },
        {
            "purple",
            "#800080"
        },
        {
            "rebeccapurple",
            "#663399"
        },
        {
            "red",
            "#FF0000"
        },
        {
            "rosybrown",
            "#BC8F8F"
        },
        {
            "royalblue",
            "#4169E1"
        },
        {
            "saddlebrown",
            "#8B4513"
        },
        {
            "salmon",
            "#FA8072"
        },
        {
            "sandybrown",
            "#F4A460"
        },
        {
            "seagreen",
            "#2E8B57"
        },
        {
            "seashell",
            "#FFF5EE"
        },
        {
            "sienna",
            "#A0522D"
        },
        {
            "silver",
            "#C0C0C0"
        },
        {
            "skyblue",
            "#87CEEB"
        },
        {
            "slateblue",
            "#6A5ACD"
        },
        {
            "slategray",
            "#708090"
        },
        {
            "slategrey",
            "#708090"
        },
        {
            "snow",
            "#FFFAFA"
        },
        {
            "springgreen",
            "#00FF7F"
        },
        {
            "steelblue",
            "#4682B4"
        },
        {
            "tan",
            "#D2B48C"
        },
        {
            "teal",
            "#008080"
        },
        {
            "thistle",
            "#D8BFD8"
        },
        {
            "tomato",
            "#FF6347"
        },
        {
            "turquoise",
            "#40E0D0"
        },
        {
            "violet",
            "#EE82EE"
        },
        {
            "wheat",
            "#F5DEB3"
        },
        {
            "white",
            "#FFFFFF"
        },
        {
            "whitesmoke",
            "#F5F5F5"
        },
        {
            "yellow",
            "#FFFF00"
        },
        {
            "yellowgreen",
            "#9ACD32"
        }
    };

    /// <summary>
    /// Represents all CSS colors and their RGBA values
    /// </summary>
    public static readonly Dictionary<string, Argb.Argb> CssToRgbaColors = new()
    {
        {
            "AliceBlue",
            new Argb.Argb(0xF0, 0xF8, 0xFF, 10)
        },
        {
            "AntiqueWhite",
            new Argb.Argb(0xFA, 0xEB, 0xD7, 10)
        },
        {
            "Aqua",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "Aquamarine",
            new Argb.Argb(0x7F, 0xFF, 0xD4, 10)
        },
        {
            "Azure",
            new Argb.Argb(0xF0, 0xFF, 0xFF, 10)
        },
        {
            "Beige",
            new Argb.Argb(0xF5, 0xF5, 0xDC, 10)
        },
        {
            "Bisque",
            new Argb.Argb(0xFF, 0xE4, 0xC4, 10)
        },
        {
            "Black",
            new Argb.Argb(0x00, 0x00, 0x00, 10)
        },
        {
            "BlanchedAlmond",
            new Argb.Argb(0xFF, 0xEB, 0xCD, 10)
        },
        {
            "Blue",
            new Argb.Argb(0x00, 0x00, 0xFF, 10)
        },
        {
            "BlueViolet",
            new Argb.Argb(0x8A, 0x2B, 0xE2, 10)
        },
        {
            "Brown",
            new Argb.Argb(0xA5, 0x2A, 0x2A, 10)
        },
        {
            "BurlyWood",
            new Argb.Argb(0xDE, 0xB8, 0x87, 10)
        },
        {
            "CadetBlue",
            new Argb.Argb(0x5F, 0x9E, 0xA0, 10)
        },
        {
            "Chartreuse",
            new Argb.Argb(0x7F, 0xFF, 0x00, 10)
        },
        {
            "Chocolate",
            new Argb.Argb(0xD2, 0x69, 0x1E, 10)
        },
        {
            "Coral",
            new Argb.Argb(0xFF, 0x7F, 0x50, 10)
        },
        {
            "CornflowerBlue",
            new Argb.Argb(0x64, 0x95, 0xED, 10)
        },
        {
            "Cornsilk",
            new Argb.Argb(0xFF, 0xF8, 0xDC, 10)
        },
        {
            "Crimson",
            new Argb.Argb(0xDC, 0x14, 0x3C, 10)
        },
        {
            "Cyan",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "DarkBlue",
            new Argb.Argb(0x00, 0x00, 0x8B, 10)
        },
        {
            "DarkCyan",
            new Argb.Argb(0x00, 0x8B, 0x8B, 10)
        },
        {
            "DarkGoldenRod",
            new Argb.Argb(0xB8, 0x86, 0x0B, 10)
        },
        {
            "DarkGray",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "DarkGrey",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "DarkGreen",
            new Argb.Argb(0x00, 0x64, 0x00, 10)
        },
        {
            "DarkKhaki",
            new Argb.Argb(0xBD, 0xB7, 0x6B, 10)
        },
        {
            "DarkMagenta",
            new Argb.Argb(0x8B, 0x00, 0x8B, 10)
        },
        {
            "DarkOliveGreen",
            new Argb.Argb(0x55, 0x6B, 0x2F, 10)
        },
        {
            "DarkOrange",
            new Argb.Argb(0xFF, 0x8C, 0x00, 10)
        },
        {
            "DarkOrchid",
            new Argb.Argb(0x99, 0x32, 0xCC, 10)
        },
        {
            "DarkRed",
            new Argb.Argb(0x8B, 0x00, 0x00, 10)
        },
        {
            "DarkSalmon",
            new Argb.Argb(0xE9, 0x96, 0x7A, 10)
        },
        {
            "DarkSeaGreen",
            new Argb.Argb(0x8F, 0xBC, 0x8F, 10)
        },
        {
            "DarkSlateBlue",
            new Argb.Argb(0x48, 0x3D, 0x8B, 10)
        },
        {
            "DarkSlateGray",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "DarkSlateGrey",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "DarkTurquoise",
            new Argb.Argb(0x00, 0xCE, 0xD1, 10)
        },
        {
            "DarkViolet",
            new Argb.Argb(0x94, 0x00, 0xD3, 10)
        },
        {
            "DeepPink",
            new Argb.Argb(0xFF, 0x14, 0x93, 10)
        },
        {
            "DeepSkyBlue",
            new Argb.Argb(0x00, 0xBF, 0xFF, 10)
        },
        {
            "DimGray",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "DimGrey",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "DodgerBlue",
            new Argb.Argb(0x1E, 0x90, 0xFF, 10)
        },
        {
            "FireBrick",
            new Argb.Argb(0xB2, 0x22, 0x22, 10)
        },
        {
            "FloralWhite",
            new Argb.Argb(0xFF, 0xFA, 0xF0, 10)
        },
        {
            "ForestGreen",
            new Argb.Argb(0x22, 0x8B, 0x22, 10)
        },
        {
            "Fuchsia",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "Gainsboro",
            new Argb.Argb(0xDC, 0xDC, 0xDC, 10)
        },
        {
            "GhostWhite",
            new Argb.Argb(0xF8, 0xF8, 0xFF, 10)
        },
        {
            "Gold",
            new Argb.Argb(0xFF, 0xD7, 0x00, 10)
        },
        {
            "GoldenRod",
            new Argb.Argb(0xDA, 0xA5, 0x20, 10)
        },
        {
            "Gray",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "Grey",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "Green",
            new Argb.Argb(0x00, 0x80, 0x00, 10)
        },
        {
            "GreenYellow",
            new Argb.Argb(0xAD, 0xFF, 0x2F, 10)
        },
        {
            "HoneyDew",
            new Argb.Argb(0xF0, 0xFF, 0xF0, 10)
        },
        {
            "HotPink",
            new Argb.Argb(0xFF, 0x69, 0xB4, 10)
        },
        {
            "IndianRed",
            new Argb.Argb(0xCD, 0x5C, 0x5C, 10)
        },
        {
            "Indigo",
            new Argb.Argb(0x4B, 0x00, 0x82, 10)
        },
        {
            "Ivory",
            new Argb.Argb(0xFF, 0xFF, 0xF0, 10)
        },
        {
            "Khaki",
            new Argb.Argb(0xF0, 0xE6, 0x8C, 10)
        },
        {
            "Lavender",
            new Argb.Argb(0xE6, 0xE6, 0xFA, 10)
        },
        {
            "LavenderBlush",
            new Argb.Argb(0xFF, 0xF0, 0xF5, 10)
        },
        {
            "LawnGreen",
            new Argb.Argb(0x7C, 0xFC, 0x00, 10)
        },
        {
            "LemonChiffon",
            new Argb.Argb(0xFF, 0xFA, 0xCD, 10)
        },
        {
            "LightBlue",
            new Argb.Argb(0xAD, 0xD8, 0xE6, 10)
        },
        {
            "LightCoral",
            new Argb.Argb(0xF0, 0x80, 0x80, 10)
        },
        {
            "LightCyan",
            new Argb.Argb(0xE0, 0xFF, 0xFF, 10)
        },
        {
            "LightGoldenRodYellow",
            new Argb.Argb(0xFA, 0xFA, 0xD2, 10)
        },
        {
            "LightGray",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "LightGrey",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "LightGreen",
            new Argb.Argb(0x90, 0xEE, 0x90, 10)
        },
        {
            "LightPink",
            new Argb.Argb(0xFF, 0xB6, 0xC1, 10)
        },
        {
            "LightSalmon",
            new Argb.Argb(0xFF, 0xA0, 0x7A, 10)
        },
        {
            "LightSeaGreen",
            new Argb.Argb(0x20, 0xB2, 0xAA, 10)
        },
        {
            "LightSkyBlue",
            new Argb.Argb(0x87, 0xCE, 0xFA, 10)
        },
        {
            "LightSlateGray",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "LightSlateGrey",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "LightSteelBlue",
            new Argb.Argb(0xB0, 0xC4, 0xDE, 10)
        },
        {
            "LightYellow",
            new Argb.Argb(0xFF, 0xFF, 0xE0, 10)
        },
        {
            "Lime",
            new Argb.Argb(0x00, 0xFF, 0x00, 10)
        },
        {
            "LimeGreen",
            new Argb.Argb(0x32, 0xCD, 0x32, 10)
        },
        {
            "Linen",
            new Argb.Argb(0xFA, 0xF0, 0xE6, 10)
        },
        {
            "Magenta",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "Maroon",
            new Argb.Argb(0x80, 0x00, 0x00, 10)
        },
        {
            "MediumAquaMarine",
            new Argb.Argb(0x66, 0xCD, 0xAA, 10)
        },
        {
            "MediumBlue",
            new Argb.Argb(0x00, 0x00, 0xCD, 10)
        },
        {
            "MediumOrchid",
            new Argb.Argb(0xBA, 0x55, 0xD3, 10)
        },
        {
            "MediumPurple",
            new Argb.Argb(0x93, 0x70, 0xDB, 10)
        },
        {
            "MediumSeaGreen",
            new Argb.Argb(0x3C, 0xB3, 0x71, 10)
        },
        {
            "MediumSlateBlue",
            new Argb.Argb(0x7B, 0x68, 0xEE, 10)
        },
        {
            "MediumSpringGreen",
            new Argb.Argb(0x00, 0xFA, 0x9A, 10)
        },
        {
            "MediumTurquoise",
            new Argb.Argb(0x48, 0xD1, 0xCC, 10)
        },
        {
            "MediumVioletRed",
            new Argb.Argb(0xC7, 0x15, 0x85, 10)
        },
        {
            "MidnightBlue",
            new Argb.Argb(0x19, 0x19, 0x70, 10)
        },
        {
            "MintCream",
            new Argb.Argb(0xF5, 0xFF, 0xFA, 10)
        },
        {
            "MistyRose",
            new Argb.Argb(0xFF, 0xE4, 0xE1, 10)
        },
        {
            "Moccasin",
            new Argb.Argb(0xFF, 0xE4, 0xB5, 10)
        },
        {
            "NavajoWhite",
            new Argb.Argb(0xFF, 0xDE, 0xAD, 10)
        },
        {
            "Navy",
            new Argb.Argb(0x00, 0x00, 0x80, 10)
        },
        {
            "OldLace",
            new Argb.Argb(0xFD, 0xF5, 0xE6, 10)
        },
        {
            "Olive",
            new Argb.Argb(0x80, 0x80, 0x00, 10)
        },
        {
            "OliveDrab",
            new Argb.Argb(0x6B, 0x8E, 0x23, 10)
        },
        {
            "Orange",
            new Argb.Argb(0xFF, 0xA5, 0x00, 10)
        },
        {
            "OrangeRed",
            new Argb.Argb(0xFF, 0x45, 0x00, 10)
        },
        {
            "Orchid",
            new Argb.Argb(0xDA, 0x70, 0xD6, 10)
        },
        {
            "PaleGoldenRod",
            new Argb.Argb(0xEE, 0xE8, 0xAA, 10)
        },
        {
            "PaleGreen",
            new Argb.Argb(0x98, 0xFB, 0x98, 10)
        },
        {
            "PaleTurquoise",
            new Argb.Argb(0xAF, 0xEE, 0xEE, 10)
        },
        {
            "PaleVioletRed",
            new Argb.Argb(0xDB, 0x70, 0x93, 10)
        },
        {
            "PapayaWhip",
            new Argb.Argb(0xFF, 0xEF, 0xD5, 10)
        },
        {
            "PeachPuff",
            new Argb.Argb(0xFF, 0xDA, 0xB9, 10)
        },
        {
            "Peru",
            new Argb.Argb(0xCD, 0x85, 0x3F, 10)
        },
        {
            "Pink",
            new Argb.Argb(0xFF, 0xC0, 0xCB, 10)
        },
        {
            "Plum",
            new Argb.Argb(0xDD, 0xA0, 0xDD, 10)
        },
        {
            "PowderBlue",
            new Argb.Argb(0xB0, 0xE0, 0xE6, 10)
        },
        {
            "Purple",
            new Argb.Argb(0x80, 0x00, 0x80, 10)
        },
        {
            "RebeccaPurple",
            new Argb.Argb(0x66, 0x33, 0x99, 10)
        },
        {
            "Red",
            new Argb.Argb(0xFF, 0x00, 0x00, 10)
        },
        {
            "RosyBrown",
            new Argb.Argb(0xBC, 0x8F, 0x8F, 10)
        },
        {
            "RoyalBlue",
            new Argb.Argb(0x41, 0x69, 0xE1, 10)
        },
        {
            "SaddleBrown",
            new Argb.Argb(0x8B, 0x45, 0x13, 10)
        },
        {
            "Salmon",
            new Argb.Argb(0xFA, 0x80, 0x72, 10)
        },
        {
            "SandyBrown",
            new Argb.Argb(0xF4, 0xA4, 0x60, 10)
        },
        {
            "SeaGreen",
            new Argb.Argb(0x2E, 0x8B, 0x57, 10)
        },
        {
            "SeaShell",
            new Argb.Argb(0xFF, 0xF5, 0xEE, 10)
        },
        {
            "Sienna",
            new Argb.Argb(0xA0, 0x52, 0x2D, 10)
        },
        {
            "Silver",
            new Argb.Argb(0xC0, 0xC0, 0xC0, 10)
        },
        {
            "SkyBlue",
            new Argb.Argb(0x87, 0xCE, 0xEB, 10)
        },
        {
            "SlateBlue",
            new Argb.Argb(0x6A, 0x5A, 0xCD, 10)
        },
        {
            "SlateGray",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "SlateGrey",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "Snow",
            new Argb.Argb(0xFF, 0xFA, 0xFA, 10)
        },
        {
            "SpringGreen",
            new Argb.Argb(0x00, 0xFF, 0x7F, 10)
        },
        {
            "SteelBlue",
            new Argb.Argb(0x46, 0x82, 0xB4, 10)
        },
        {
            "Tan",
            new Argb.Argb(0xD2, 0xB4, 0x8C, 10)
        },
        {
            "Teal",
            new Argb.Argb(0x00, 0x80, 0x80, 10)
        },
        {
            "Thistle",
            new Argb.Argb(0xD8, 0xBF, 0xD8, 10)
        },
        {
            "Tomato",
            new Argb.Argb(0xFF, 0x63, 0x47, 10)
        },
        {
            "Turquoise",
            new Argb.Argb(0x40, 0xE0, 0xD0, 10)
        },
        {
            "Violet",
            new Argb.Argb(0xEE, 0x82, 0xEE, 10)
        },
        {
            "Wheat",
            new Argb.Argb(0xF5, 0xDE, 0xB3, 10)
        },
        {
            "White",
            new Argb.Argb(0xFF, 0xFF, 0xFF, 10)
        },
        {
            "WhiteSmoke",
            new Argb.Argb(0xF5, 0xF5, 0xF5, 10)
        },
        {
            "Yellow",
            new Argb.Argb(0xFF, 0xFF, 0x00, 10)
        },
        {
            "YellowGreen",
            new Argb.Argb(0x9A, 0xCD, 0x32, 10)
        }
    };

    /// <summary>
    /// Represents all CSS colors (but lowercase) and their RGBA values
    /// </summary>
    public static readonly Dictionary<string, Argb.Argb> LowercaseCssToRgbaColors = new()
    {
        {
            "aliceblue",
            new Argb.Argb(0xF0, 0xF8, 0xFF, 10)
        },
        {
            "antiquewhite",
            new Argb.Argb(0xFA, 0xEB, 0xD7, 10)
        },
        {
            "aqua",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "aquamarine",
            new Argb.Argb(0x7F, 0xFF, 0xD4, 10)
        },
        {
            "azure",
            new Argb.Argb(0xF0, 0xFF, 0xFF, 10)
        },
        {
            "beige",
            new Argb.Argb(0xF5, 0xF5, 0xDC, 10)
        },
        {
            "bisque",
            new Argb.Argb(0xFF, 0xE4, 0xC4, 10)
        },
        {
            "black",
            new Argb.Argb(0x00, 0x00, 0x00, 10)
        },
        {
            "blanchedalmond",
            new Argb.Argb(0xFF, 0xEB, 0xCD, 10)
        },
        {
            "blue",
            new Argb.Argb(0x00, 0x00, 0xFF, 10)
        },
        {
            "blueviolet",
            new Argb.Argb(0x8A, 0x2B, 0xE2, 10)
        },
        {
            "brown",
            new Argb.Argb(0xA5, 0x2A, 0x2A, 10)
        },
        {
            "burlywood",
            new Argb.Argb(0xDE, 0xB8, 0x87, 10)
        },
        {
            "cadetblue",
            new Argb.Argb(0x5F, 0x9E, 0xA0, 10)
        },
        {
            "chartreuse",
            new Argb.Argb(0x7F, 0xFF, 0x00, 10)
        },
        {
            "chocolate",
            new Argb.Argb(0xD2, 0x69, 0x1E, 10)
        },
        {
            "coral",
            new Argb.Argb(0xFF, 0x7F, 0x50, 10)
        },
        {
            "cornflowerblue",
            new Argb.Argb(0x64, 0x95, 0xED, 10)
        },
        {
            "cornsilk",
            new Argb.Argb(0xFF, 0xF8, 0xDC, 10)
        },
        {
            "crimson",
            new Argb.Argb(0xDC, 0x14, 0x3C, 10)
        },
        {
            "cyan",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "darkblue",
            new Argb.Argb(0x00, 0x00, 0x8B, 10)
        },
        {
            "darkcyan",
            new Argb.Argb(0x00, 0x8B, 0x8B, 10)
        },
        {
            "darkgoldenrod",
            new Argb.Argb(0xB8, 0x86, 0x0B, 10)
        },
        {
            "darkgray",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "darkgrey",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "darkgreen",
            new Argb.Argb(0x00, 0x64, 0x00, 10)
        },
        {
            "darkkhaki",
            new Argb.Argb(0xBD, 0xB7, 0x6B, 10)
        },
        {
            "darkmagenta",
            new Argb.Argb(0x8B, 0x00, 0x8B, 10)
        },
        {
            "darkolivegreen",
            new Argb.Argb(0x55, 0x6B, 0x2F, 10)
        },
        {
            "darkorange",
            new Argb.Argb(0xFF, 0x8C, 0x00, 10)
        },
        {
            "darkorchid",
            new Argb.Argb(0x99, 0x32, 0xCC, 10)
        },
        {
            "darkred",
            new Argb.Argb(0x8B, 0x00, 0x00, 10)
        },
        {
            "darksalmon",
            new Argb.Argb(0xE9, 0x96, 0x7A, 10)
        },
        {
            "darkseagreen",
            new Argb.Argb(0x8F, 0xBC, 0x8F, 10)
        },
        {
            "darkslateblue",
            new Argb.Argb(0x48, 0x3D, 0x8B, 10)
        },
        {
            "darkslategray",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "darkslategrey",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "darkturquoise",
            new Argb.Argb(0x00, 0xCE, 0xD1, 10)
        },
        {
            "darkviolet",
            new Argb.Argb(0x94, 0x00, 0xD3, 10)
        },
        {
            "deeppink",
            new Argb.Argb(0xFF, 0x14, 0x93, 10)
        },
        {
            "deepskyblue",
            new Argb.Argb(0x00, 0xBF, 0xFF, 10)
        },
        {
            "dimgray",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "dimgrey",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "dodgerblue",
            new Argb.Argb(0x1E, 0x90, 0xFF, 10)
        },
        {
            "firebrick",
            new Argb.Argb(0xB2, 0x22, 0x22, 10)
        },
        {
            "floralwhite",
            new Argb.Argb(0xFF, 0xFA, 0xF0, 10)
        },
        {
            "forestgreen",
            new Argb.Argb(0x22, 0x8B, 0x22, 10)
        },
        {
            "fuchsia",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "gainsboro",
            new Argb.Argb(0xDC, 0xDC, 0xDC, 10)
        },
        {
            "ghostwhite",
            new Argb.Argb(0xF8, 0xF8, 0xFF, 10)
        },
        {
            "gold",
            new Argb.Argb(0xFF, 0xD7, 0x00, 10)
        },
        {
            "goldenrod",
            new Argb.Argb(0xDA, 0xA5, 0x20, 10)
        },
        {
            "gray",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "grey",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "green",
            new Argb.Argb(0x00, 0x80, 0x00, 10)
        },
        {
            "greenyellow",
            new Argb.Argb(0xAD, 0xFF, 0x2F, 10)
        },
        {
            "honeydew",
            new Argb.Argb(0xF0, 0xFF, 0xF0, 10)
        },
        {
            "hotpink",
            new Argb.Argb(0xFF, 0x69, 0xB4, 10)
        },
        {
            "indianred",
            new Argb.Argb(0xCD, 0x5C, 0x5C, 10)
        },
        {
            "indigo",
            new Argb.Argb(0x4B, 0x00, 0x82, 10)
        },
        {
            "ivory",
            new Argb.Argb(0xFF, 0xFF, 0xF0, 10)
        },
        {
            "khaki",
            new Argb.Argb(0xF0, 0xE6, 0x8C, 10)
        },
        {
            "lavender",
            new Argb.Argb(0xE6, 0xE6, 0xFA, 10)
        },
        {
            "lavenderblush",
            new Argb.Argb(0xFF, 0xF0, 0xF5, 10)
        },
        {
            "lawngreen",
            new Argb.Argb(0x7C, 0xFC, 0x00, 10)
        },
        {
            "lemonchiffon",
            new Argb.Argb(0xFF, 0xFA, 0xCD, 10)
        },
        {
            "lightblue",
            new Argb.Argb(0xAD, 0xD8, 0xE6, 10)
        },
        {
            "lightcoral",
            new Argb.Argb(0xF0, 0x80, 0x80, 10)
        },
        {
            "lightcyan",
            new Argb.Argb(0xE0, 0xFF, 0xFF, 10)
        },
        {
            "lightgoldenrodyellow",
            new Argb.Argb(0xFA, 0xFA, 0xD2, 10)
        },
        {
            "lightgray",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "lightgrey",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "lightgreen",
            new Argb.Argb(0x90, 0xEE, 0x90, 10)
        },
        {
            "lightpink",
            new Argb.Argb(0xFF, 0xB6, 0xC1, 10)
        },
        {
            "lightsalmon",
            new Argb.Argb(0xFF, 0xA0, 0x7A, 10)
        },
        {
            "lightseagreen",
            new Argb.Argb(0x20, 0xB2, 0xAA, 10)
        },
        {
            "lightskyblue",
            new Argb.Argb(0x87, 0xCE, 0xFA, 10)
        },
        {
            "lightslategray",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "lightslategrey",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "lightsteelblue",
            new Argb.Argb(0xB0, 0xC4, 0xDE, 10)
        },
        {
            "lightyellow",
            new Argb.Argb(0xFF, 0xFF, 0xE0, 10)
        },
        {
            "lime",
            new Argb.Argb(0x00, 0xFF, 0x00, 10)
        },
        {
            "limegreen",
            new Argb.Argb(0x32, 0xCD, 0x32, 10)
        },
        {
            "linen",
            new Argb.Argb(0xFA, 0xF0, 0xE6, 10)
        },
        {
            "magenta",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "maroon",
            new Argb.Argb(0x80, 0x00, 0x00, 10)
        },
        {
            "mediumaquamarine",
            new Argb.Argb(0x66, 0xCD, 0xAA, 10)
        },
        {
            "mediumblue",
            new Argb.Argb(0x00, 0x00, 0xCD, 10)
        },
        {
            "mediumorchid",
            new Argb.Argb(0xBA, 0x55, 0xD3, 10)
        },
        {
            "mediumpurple",
            new Argb.Argb(0x93, 0x70, 0xDB, 10)
        },
        {
            "mediumseagreen",
            new Argb.Argb(0x3C, 0xB3, 0x71, 10)
        },
        {
            "mediumslateblue",
            new Argb.Argb(0x7B, 0x68, 0xEE, 10)
        },
        {
            "mediumspringgreen",
            new Argb.Argb(0x00, 0xFA, 0x9A, 10)
        },
        {
            "mediumturquoise",
            new Argb.Argb(0x48, 0xD1, 0xCC, 10)
        },
        {
            "mediumvioletred",
            new Argb.Argb(0xC7, 0x15, 0x85, 10)
        },
        {
            "midnightblue",
            new Argb.Argb(0x19, 0x19, 0x70, 10)
        },
        {
            "mintcream",
            new Argb.Argb(0xF5, 0xFF, 0xFA, 10)
        },
        {
            "mistyrose",
            new Argb.Argb(0xFF, 0xE4, 0xE1, 10)
        },
        {
            "moccasin",
            new Argb.Argb(0xFF, 0xE4, 0xB5, 10)
        },
        {
            "navajowhite",
            new Argb.Argb(0xFF, 0xDE, 0xAD, 10)
        },
        {
            "navy",
            new Argb.Argb(0x00, 0x00, 0x80, 10)
        },
        {
            "oldlace",
            new Argb.Argb(0xFD, 0xF5, 0xE6, 10)
        },
        {
            "olive",
            new Argb.Argb(0x80, 0x80, 0x00, 10)
        },
        {
            "olivedrab",
            new Argb.Argb(0x6B, 0x8E, 0x23, 10)
        },
        {
            "orange",
            new Argb.Argb(0xFF, 0xA5, 0x00, 10)
        },
        {
            "orangered",
            new Argb.Argb(0xFF, 0x45, 0x00, 10)
        },
        {
            "orchid",
            new Argb.Argb(0xDA, 0x70, 0xD6, 10)
        },
        {
            "palegoldenrod",
            new Argb.Argb(0xEE, 0xE8, 0xAA, 10)
        },
        {
            "palegreen",
            new Argb.Argb(0x98, 0xFB, 0x98, 10)
        },
        {
            "paleturquoise",
            new Argb.Argb(0xAF, 0xEE, 0xEE, 10)
        },
        {
            "palevioletred",
            new Argb.Argb(0xDB, 0x70, 0x93, 10)
        },
        {
            "papayawhip",
            new Argb.Argb(0xFF, 0xEF, 0xD5, 10)
        },
        {
            "peachpuff",
            new Argb.Argb(0xFF, 0xDA, 0xB9, 10)
        },
        {
            "peru",
            new Argb.Argb(0xCD, 0x85, 0x3F, 10)
        },
        {
            "pink",
            new Argb.Argb(0xFF, 0xC0, 0xCB, 10)
        },
        {
            "plum",
            new Argb.Argb(0xDD, 0xA0, 0xDD, 10)
        },
        {
            "powderblue",
            new Argb.Argb(0xB0, 0xE0, 0xE6, 10)
        },
        {
            "purple",
            new Argb.Argb(0x80, 0x00, 0x80, 10)
        },
        {
            "rebeccapurple",
            new Argb.Argb(0x66, 0x33, 0x99, 10)
        },
        {
            "red",
            new Argb.Argb(0xFF, 0x00, 0x00, 10)
        },
        {
            "rosybrown",
            new Argb.Argb(0xBC, 0x8F, 0x8F, 10)
        },
        {
            "royalblue",
            new Argb.Argb(0x41, 0x69, 0xE1, 10)
        },
        {
            "saddlebrown",
            new Argb.Argb(0x8B, 0x45, 0x13, 10)
        },
        {
            "salmon",
            new Argb.Argb(0xFA, 0x80, 0x72, 10)
        },
        {
            "sandybrown",
            new Argb.Argb(0xF4, 0xA4, 0x60, 10)
        },
        {
            "seagreen",
            new Argb.Argb(0x2E, 0x8B, 0x57, 10)
        },
        {
            "seashell",
            new Argb.Argb(0xFF, 0xF5, 0xEE, 10)
        },
        {
            "sienna",
            new Argb.Argb(0xA0, 0x52, 0x2D, 10)
        },
        {
            "silver",
            new Argb.Argb(0xC0, 0xC0, 0xC0, 10)
        },
        {
            "skyblue",
            new Argb.Argb(0x87, 0xCE, 0xEB, 10)
        },
        {
            "slateblue",
            new Argb.Argb(0x6A, 0x5A, 0xCD, 10)
        },
        {
            "slategray",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "slategrey",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "snow",
            new Argb.Argb(0xFF, 0xFA, 0xFA, 10)
        },
        {
            "springgreen",
            new Argb.Argb(0x00, 0xFF, 0x7F, 10)
        },
        {
            "steelblue",
            new Argb.Argb(0x46, 0x82, 0xB4, 10)
        },
        {
            "tan",
            new Argb.Argb(0xD2, 0xB4, 0x8C, 10)
        },
        {
            "teal",
            new Argb.Argb(0x00, 0x80, 0x80, 10)
        },
        {
            "thistle",
            new Argb.Argb(0xD8, 0xBF, 0xD8, 10)
        },
        {
            "tomato",
            new Argb.Argb(0xFF, 0x63, 0x47, 10)
        },
        {
            "turquoise",
            new Argb.Argb(0x40, 0xE0, 0xD0, 10)
        },
        {
            "violet",
            new Argb.Argb(0xEE, 0x82, 0xEE, 10)
        },
        {
            "wheat",
            new Argb.Argb(0xF5, 0xDE, 0xB3, 10)
        },
        {
            "white",
            new Argb.Argb(0xFF, 0xFF, 0xFF, 10)
        },
        {
            "whitesmoke",
            new Argb.Argb(0xF5, 0xF5, 0xF5, 10)
        },
        {
            "yellow",
            new Argb.Argb(0xFF, 0xFF, 0x00, 10)
        },
        {
            "yellowgreen",
            new Argb.Argb(0x9A, 0xCD, 0x32, 10)
        }
    };

    /// <summary>
    /// Represents all CSS colors (but uppercase) and their RGBA values
    /// </summary>
    public static readonly Dictionary<string, Argb.Argb> UppercaseCssToRgbaColors = new()
    {
        {
            "ALICEBLUE",
            new Argb.Argb(0xF0, 0xF8, 0xFF, 10)
        },
        {
            "ANTIQUEWHITE",
            new Argb.Argb(0xFA, 0xEB, 0xD7, 10)
        },
        {
            "AQUA",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "AQUAMARINE",
            new Argb.Argb(0x7F, 0xFF, 0xD4, 10)
        },
        {
            "AZURE",
            new Argb.Argb(0xF0, 0xFF, 0xFF, 10)
        },
        {
            "BEIGE",
            new Argb.Argb(0xF5, 0xF5, 0xDC, 10)
        },
        {
            "BISQUE",
            new Argb.Argb(0xFF, 0xE4, 0xC4, 10)
        },
        {
            "BLACK",
            new Argb.Argb(0x00, 0x00, 0x00, 10)
        },
        {
            "BLANCHEDALMOND",
            new Argb.Argb(0xFF, 0xEB, 0xCD, 10)
        },
        {
            "BLUE",
            new Argb.Argb(0x00, 0x00, 0xFF, 10)
        },
        {
            "BLUEVIOLET",
            new Argb.Argb(0x8A, 0x2B, 0xE2, 10)
        },
        {
            "BROWN",
            new Argb.Argb(0xA5, 0x2A, 0x2A, 10)
        },
        {
            "BURLYWOOD",
            new Argb.Argb(0xDE, 0xB8, 0x87, 10)
        },
        {
            "CADETBLUE",
            new Argb.Argb(0x5F, 0x9E, 0xA0, 10)
        },
        {
            "CHARTREUSE",
            new Argb.Argb(0x7F, 0xFF, 0x00, 10)
        },
        {
            "CHOCOLATE",
            new Argb.Argb(0xD2, 0x69, 0x1E, 10)
        },
        {
            "CORAL",
            new Argb.Argb(0xFF, 0x7F, 0x50, 10)
        },
        {
            "CORNFLOWERBLUE",
            new Argb.Argb(0x64, 0x95, 0xED, 10)
        },
        {
            "CORNSILK",
            new Argb.Argb(0xFF, 0xF8, 0xDC, 10)
        },
        {
            "CRIMSON",
            new Argb.Argb(0xDC, 0x14, 0x3C, 10)
        },
        {
            "CYAN",
            new Argb.Argb(0x00, 0xFF, 0xFF, 10)
        },
        {
            "DARKBLUE",
            new Argb.Argb(0x00, 0x00, 0x8B, 10)
        },
        {
            "DARKCYAN",
            new Argb.Argb(0x00, 0x8B, 0x8B, 10)
        },
        {
            "DARKGOLDENROD",
            new Argb.Argb(0xB8, 0x86, 0x0B, 10)
        },
        {
            "DARKGRAY",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "DARKGREY",
            new Argb.Argb(0xA9, 0xA9, 0xA9, 10)
        },
        {
            "DARKGREEN",
            new Argb.Argb(0x00, 0x64, 0x00, 10)
        },
        {
            "DARKKHAKI",
            new Argb.Argb(0xBD, 0xB7, 0x6B, 10)
        },
        {
            "DARKMAGENTA",
            new Argb.Argb(0x8B, 0x00, 0x8B, 10)
        },
        {
            "DARKOLIVEGREEN",
            new Argb.Argb(0x55, 0x6B, 0x2F, 10)
        },
        {
            "DARKORANGE",
            new Argb.Argb(0xFF, 0x8C, 0x00, 10)
        },
        {
            "DARKORCHID",
            new Argb.Argb(0x99, 0x32, 0xCC, 10)
        },
        {
            "DARKRED",
            new Argb.Argb(0x8B, 0x00, 0x00, 10)
        },
        {
            "DARKSALMON",
            new Argb.Argb(0xE9, 0x96, 0x7A, 10)
        },
        {
            "DARKSEAGREEN",
            new Argb.Argb(0x8F, 0xBC, 0x8F, 10)
        },
        {
            "DARKSLATEBLUE",
            new Argb.Argb(0x48, 0x3D, 0x8B, 10)
        },
        {
            "DARKSLATEGRAY",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "DARKSLATEGREY",
            new Argb.Argb(0x2F, 0x4F, 0x4F, 10)
        },
        {
            "DARKTURQUOISE",
            new Argb.Argb(0x00, 0xCE, 0xD1, 10)
        },
        {
            "DARKVIOLET",
            new Argb.Argb(0x94, 0x00, 0xD3, 10)
        },
        {
            "DEEPPINK",
            new Argb.Argb(0xFF, 0x14, 0x93, 10)
        },
        {
            "DEEPSKYBLUE",
            new Argb.Argb(0x00, 0xBF, 0xFF, 10)
        },
        {
            "DIMGRAY",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "DIMGREY",
            new Argb.Argb(0x69, 0x69, 0x69, 10)
        },
        {
            "DODGERBLUE",
            new Argb.Argb(0x1E, 0x90, 0xFF, 10)
        },
        {
            "FIREBRICK",
            new Argb.Argb(0xB2, 0x22, 0x22, 10)
        },
        {
            "FLORALWHITE",
            new Argb.Argb(0xFF, 0xFA, 0xF0, 10)
        },
        {
            "FORESTGREEN",
            new Argb.Argb(0x22, 0x8B, 0x22, 10)
        },
        {
            "FUCHSIA",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "GAINSBORO",
            new Argb.Argb(0xDC, 0xDC, 0xDC, 10)
        },
        {
            "GHOSTWHITE",
            new Argb.Argb(0xF8, 0xF8, 0xFF, 10)
        },
        {
            "GOLD",
            new Argb.Argb(0xFF, 0xD7, 0x00, 10)
        },
        {
            "GOLDENROD",
            new Argb.Argb(0xDA, 0xA5, 0x20, 10)
        },
        {
            "GRAY",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "GREY",
            new Argb.Argb(0x80, 0x80, 0x80, 10)
        },
        {
            "GREEN",
            new Argb.Argb(0x00, 0x80, 0x00, 10)
        },
        {
            "GREENYELLOW",
            new Argb.Argb(0xAD, 0xFF, 0x2F, 10)
        },
        {
            "HONEYDEW",
            new Argb.Argb(0xF0, 0xFF, 0xF0, 10)
        },
        {
            "HOTPINK",
            new Argb.Argb(0xFF, 0x69, 0xB4, 10)
        },
        {
            "INDIANRED",
            new Argb.Argb(0xCD, 0x5C, 0x5C, 10)
        },
        {
            "INDIGO",
            new Argb.Argb(0x4B, 0x00, 0x82, 10)
        },
        {
            "IVORY",
            new Argb.Argb(0xFF, 0xFF, 0xF0, 10)
        },
        {
            "KHAKI",
            new Argb.Argb(0xF0, 0xE6, 0x8C, 10)
        },
        {
            "LAVENDER",
            new Argb.Argb(0xE6, 0xE6, 0xFA, 10)
        },
        {
            "LAVENDERBLUSH",
            new Argb.Argb(0xFF, 0xF0, 0xF5, 10)
        },
        {
            "LAWNGREEN",
            new Argb.Argb(0x7C, 0xFC, 0x00, 10)
        },
        {
            "LEMONCHIFFON",
            new Argb.Argb(0xFF, 0xFA, 0xCD, 10)
        },
        {
            "LIGHTBLUE",
            new Argb.Argb(0xAD, 0xD8, 0xE6, 10)
        },
        {
            "LIGHTCORAL",
            new Argb.Argb(0xF0, 0x80, 0x80, 10)
        },
        {
            "LIGHTCYAN",
            new Argb.Argb(0xE0, 0xFF, 0xFF, 10)
        },
        {
            "LIGHTGOLDENRODYELLOW",
            new Argb.Argb(0xFA, 0xFA, 0xD2, 10)
        },
        {
            "LIGHTGRAY",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "LIGHTGREY",
            new Argb.Argb(0xD3, 0xD3, 0xD3, 10)
        },
        {
            "LIGHTGREEN",
            new Argb.Argb(0x90, 0xEE, 0x90, 10)
        },
        {
            "LIGHTPINK",
            new Argb.Argb(0xFF, 0xB6, 0xC1, 10)
        },
        {
            "LIGHTSALMON",
            new Argb.Argb(0xFF, 0xA0, 0x7A, 10)
        },
        {
            "LIGHTSEAGREEN",
            new Argb.Argb(0x20, 0xB2, 0xAA, 10)
        },
        {
            "LIGHTSKYBLUE",
            new Argb.Argb(0x87, 0xCE, 0xFA, 10)
        },
        {
            "LIGHTSLATEGRAY",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "LIGHTSLATEGREY",
            new Argb.Argb(0x77, 0x88, 0x99, 10)
        },
        {
            "LIGHTSTEELBLUE",
            new Argb.Argb(0xB0, 0xC4, 0xDE, 10)
        },
        {
            "LIGHTYELLOW",
            new Argb.Argb(0xFF, 0xFF, 0xE0, 10)
        },
        {
            "LIME",
            new Argb.Argb(0x00, 0xFF, 0x00, 10)
        },
        {
            "LIMEGREEN",
            new Argb.Argb(0x32, 0xCD, 0x32, 10)
        },
        {
            "LINEN",
            new Argb.Argb(0xFA, 0xF0, 0xE6, 10)
        },
        {
            "MAGENTA",
            new Argb.Argb(0xFF, 0x00, 0xFF, 10)
        },
        {
            "MAROON",
            new Argb.Argb(0x80, 0x00, 0x00, 10)
        },
        {
            "MEDIUMAQUAMARINE",
            new Argb.Argb(0x66, 0xCD, 0xAA, 10)
        },
        {
            "MEDIUMBLUE",
            new Argb.Argb(0x00, 0x00, 0xCD, 10)
        },
        {
            "MEDIUMORCHID",
            new Argb.Argb(0xBA, 0x55, 0xD3, 10)
        },
        {
            "MEDIUMPURPLE",
            new Argb.Argb(0x93, 0x70, 0xDB, 10)
        },
        {
            "MEDIUMSEAGREEN",
            new Argb.Argb(0x3C, 0xB3, 0x71, 10)
        },
        {
            "MEDIUMSLATEBLUE",
            new Argb.Argb(0x7B, 0x68, 0xEE, 10)
        },
        {
            "MEDIUMSPRINGGREEN",
            new Argb.Argb(0x00, 0xFA, 0x9A, 10)
        },
        {
            "MEDIUMTURQUOISE",
            new Argb.Argb(0x48, 0xD1, 0xCC, 10)
        },
        {
            "MEDIUMVIOLETRED",
            new Argb.Argb(0xC7, 0x15, 0x85, 10)
        },
        {
            "MIDNIGHTBLUE",
            new Argb.Argb(0x19, 0x19, 0x70, 10)
        },
        {
            "MINTCREAM",
            new Argb.Argb(0xF5, 0xFF, 0xFA, 10)
        },
        {
            "MISTYROSE",
            new Argb.Argb(0xFF, 0xE4, 0xE1, 10)
        },
        {
            "MOCCASIN",
            new Argb.Argb(0xFF, 0xE4, 0xB5, 10)
        },
        {
            "NAVAJOWHITE",
            new Argb.Argb(0xFF, 0xDE, 0xAD, 10)
        },
        {
            "NAVY",
            new Argb.Argb(0x00, 0x00, 0x80, 10)
        },
        {
            "OLDLACE",
            new Argb.Argb(0xFD, 0xF5, 0xE6, 10)
        },
        {
            "OLIVE",
            new Argb.Argb(0x80, 0x80, 0x00, 10)
        },
        {
            "OLIVEDRAB",
            new Argb.Argb(0x6B, 0x8E, 0x23, 10)
        },
        {
            "ORANGE",
            new Argb.Argb(0xFF, 0xA5, 0x00, 10)
        },
        {
            "ORANGERED",
            new Argb.Argb(0xFF, 0x45, 0x00, 10)
        },
        {
            "ORCHID",
            new Argb.Argb(0xDA, 0x70, 0xD6, 10)
        },
        {
            "PALEGOLDENROD",
            new Argb.Argb(0xEE, 0xE8, 0xAA, 10)
        },
        {
            "PALEGREEN",
            new Argb.Argb(0x98, 0xFB, 0x98, 10)
        },
        {
            "PALETURQUOISE",
            new Argb.Argb(0xAF, 0xEE, 0xEE, 10)
        },
        {
            "PALEVIOLETRED",
            new Argb.Argb(0xDB, 0x70, 0x93, 10)
        },
        {
            "PAPAYAWHIP",
            new Argb.Argb(0xFF, 0xEF, 0xD5, 10)
        },
        {
            "PEACHPUFF",
            new Argb.Argb(0xFF, 0xDA, 0xB9, 10)
        },
        {
            "PERU",
            new Argb.Argb(0xCD, 0x85, 0x3F, 10)
        },
        {
            "PINK",
            new Argb.Argb(0xFF, 0xC0, 0xCB, 10)
        },
        {
            "PLUM",
            new Argb.Argb(0xDD, 0xA0, 0xDD, 10)
        },
        {
            "POWDERBLUE",
            new Argb.Argb(0xB0, 0xE0, 0xE6, 10)
        },
        {
            "PURPLE",
            new Argb.Argb(0x80, 0x00, 0x80, 10)
        },
        {
            "REBECCAPURPLE",
            new Argb.Argb(0x66, 0x33, 0x99, 10)
        },
        {
            "RED",
            new Argb.Argb(0xFF, 0x00, 0x00, 10)
        },
        {
            "ROSYBROWN",
            new Argb.Argb(0xBC, 0x8F, 0x8F, 10)
        },
        {
            "ROYALBLUE",
            new Argb.Argb(0x41, 0x69, 0xE1, 10)
        },
        {
            "SADDLEBROWN",
            new Argb.Argb(0x8B, 0x45, 0x13, 10)
        },
        {
            "SALMON",
            new Argb.Argb(0xFA, 0x80, 0x72, 10)
        },
        {
            "SANDYBROWN",
            new Argb.Argb(0xF4, 0xA4, 0x60, 10)
        },
        {
            "SEAGREEN",
            new Argb.Argb(0x2E, 0x8B, 0x57, 10)
        },
        {
            "SEASHELL",
            new Argb.Argb(0xFF, 0xF5, 0xEE, 10)
        },
        {
            "SIENNA",
            new Argb.Argb(0xA0, 0x52, 0x2D, 10)
        },
        {
            "SILVER",
            new Argb.Argb(0xC0, 0xC0, 0xC0, 10)
        },
        {
            "SKYBLUE",
            new Argb.Argb(0x87, 0xCE, 0xEB, 10)
        },
        {
            "SLATEBLUE",
            new Argb.Argb(0x6A, 0x5A, 0xCD, 10)
        },
        {
            "SLATEGRAY",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "SLATEGREY",
            new Argb.Argb(0x70, 0x80, 0x90, 10)
        },
        {
            "SNOW",
            new Argb.Argb(0xFF, 0xFA, 0xFA, 10)
        },
        {
            "SPRINGGREEN",
            new Argb.Argb(0x00, 0xFF, 0x7F, 10)
        },
        {
            "STEELBLUE",
            new Argb.Argb(0x46, 0x82, 0xB4, 10)
        },
        {
            "TAN",
            new Argb.Argb(0xD2, 0xB4, 0x8C, 10)
        },
        {
            "TEAL",
            new Argb.Argb(0x00, 0x80, 0x80, 10)
        },
        {
            "THISTLE",
            new Argb.Argb(0xD8, 0xBF, 0xD8, 10)
        },
        {
            "TOMATO",
            new Argb.Argb(0xFF, 0x63, 0x47, 10)
        },
        {
            "TURQUOISE",
            new Argb.Argb(0x40, 0xE0, 0xD0, 10)
        },
        {
            "VIOLET",
            new Argb.Argb(0xEE, 0x82, 0xEE, 10)
        },
        {
            "WHEAT",
            new Argb.Argb(0xF5, 0xDE, 0xB3, 10)
        },
        {
            "WHITE",
            new Argb.Argb(0xFF, 0xFF, 0xFF, 10)
        },
        {
            "WHITESMOKE",
            new Argb.Argb(0xF5, 0xF5, 0xF5, 10)
        },
        {
            "YELLOW",
            new Argb.Argb(0xFF, 0xFF, 0x00, 10)
        },
        {
            "YELLOWGREEN",
            new Argb.Argb(0x9A, 0xCD, 0x32, 10)
        }
    };
}
