namespace ImgFX.Argb;

/// <summary>
/// Represents RGBA color.
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
/// <param name="Alpha">
/// Amount of alpha (e.g. opacity)
/// </param>
public record Argb(
    byte Red,
    byte Green,
    byte Blue,
    byte Alpha
);
