namespace ImgFX.Fonts;

/// <summary>
/// Represents a single character in a font
/// </summary>
/// <param name="Height">
/// Height of the character
/// </param>
/// <param name="Width">
/// Width of the character
/// </param>
/// <param name="Percentage">
/// Size of the character by percentages
/// </param>
/// <param name="UnicodeNumber">
/// Unicode representation of the character
/// </param>
/// <param name="Grid">
/// Representation with black &amp; white pixels
/// of this font. TRUE is Black, FALSE (default) is white.
/// By default, this is just an array. Using Height and Width,
/// we can find out its exact width and height.
/// </param>
public record FontTextTable(
    ushort Height,
    ushort Width,
    ushort? Percentage,
    ushort UnicodeNumber,
    bool[] Grid
);
