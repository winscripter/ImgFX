namespace ImgFX.Rgb;

/// <summary>
/// Represents RGB color. If you intend to use RGBA,
/// use <see cref="Argb.Argb" /> instead.
/// </summary>
/// <param name="Red">
/// Amount of red
/// </param>
/// <param name="Green">
/// Amount of green
/// </param>
/// <param name="Blue">
/// Amount of blue
/// </param>
public record Rgb(
    byte Red,
    byte Green,
    byte Blue
);
