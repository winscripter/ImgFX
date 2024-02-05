namespace ImgFX.Fonts;

/// <summary>
/// Represents information about a font.
/// </summary>
/// <param name="FontName">
/// Name of this font
/// </param>
/// <param name="Table">
/// All characters, their representation, and
/// sizes.
/// </param>
public record FontContext(
    string FontName,
    FontTextTable[] Table
);
