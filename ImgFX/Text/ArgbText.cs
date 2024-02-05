using ImgFX.Bitmap.Operations.Tools;
using ImgFX.Fonts;

namespace ImgFX.Text;

/// <summary>
/// Adds text to an image.
/// </summary>
public partial class ArgbText
{
    private readonly byte _fontSize;
    private readonly string _text;
    private readonly FontContext _font;
    private readonly ArgbRectangleHandle _selection;
    private readonly Argb.Argb _textColor;
    private readonly Argb.Argb? _backColor;
    private readonly byte _letterSpacing;

    /// <summary>
    /// Initializes a new instance of <see cref="ArgbText" />
    /// </summary>
    /// <param name="fontSize">
    /// Size of the font
    /// </param>
    /// <param name="text">
    /// Text
    /// </param>
    /// <param name="font">
    /// The font to use. Note that converting
    /// to this type of font from TTF might be
    /// a hard task.
    /// </param>
    /// <param name="selection">
    /// The rectangular selection where the
    /// text will be inserted
    /// </param>
    /// <param name="textColor">
    /// Foreground color
    /// </param>
    /// <param name="backColor">
    /// Background color
    /// </param>
    /// <param name="letterSpacing">
    /// Amount of space in pixels between the letters.
    /// Default is 2.
    /// </param>
    public ArgbText(byte fontSize, string text, FontContext font, ArgbRectangleHandle selection, Argb.Argb textColor, Argb.Argb? backColor, byte letterSpacing = 2)
    {
        _fontSize = fontSize;
        _text = text;
        _font = font;
        _selection = selection;
        _textColor = textColor;
        _backColor = backColor;
        _letterSpacing = letterSpacing;
    }

    /// <summary>
    /// Size of the font
    /// </summary>
    public byte FontSize
    {
        get
        {
            return _fontSize;
        }
    }

    /// <summary>
    /// Text to insert to the image
    /// </summary>
    public string Text
    {
        get
        {
            return _text;
        }
    }

    /// <summary>
    /// Selected font for the text
    /// </summary>
    public FontContext Font
    {
        get
        {
            return _font;
        }
    }

    /// <summary>
    /// Rectangular selection where the text is inserted
    /// </summary>
    public ArgbRectangleHandle RectangleSelection
    {
        get
        {
            return _selection;
        }
    }

    /// <summary>
    /// Color of the text
    /// </summary>
    public Argb.Argb ForegroundColor
    {
        get
        {
            return _textColor;
        }
    }

    /// <summary>
    /// Color behind the text
    /// </summary>
    public Argb.Argb? BackgroundColor
    {
        get
        {
            return _backColor;
        }
    }

    /// <summary>
    /// Amount of pixels between the letters (2 by default)
    /// </summary>
    public byte LetterSpacing
    {
        get
        {
            return _letterSpacing;
        }
    }
}
