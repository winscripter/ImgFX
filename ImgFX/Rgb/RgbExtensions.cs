namespace ImgFX.Rgb;

/// <summary>
/// Extensions for <see cref="Rgb" />
/// </summary>
public static class RgbExtensions
{
    /// <summary>
    /// Converts <see cref="Rgb" /> to its CSS representation with
    /// hexadecimal digits
    /// </summary>
    /// <param name="rgb">
    /// The input RGB context
    /// </param>
    /// <returns>
    /// Exactly what <see cref="Rgb" /> would look like in CSS.
    /// Example: <br />
    /// <c>new Rgb(0x7E, 0x4E, 0x98)</c>
    /// <br />Returned string:<br />
    /// <c>rgb(0x7E, 0x4E, 0x98)</c>
    /// </returns>
    public static string ToCssRgbHex(this Rgb rgb)
        => $"rgb(0x{rgb.Red:X2}, 0x{rgb.Green:X2}, 0x{rgb.Blue:X2})";

    /// <summary>
    /// Converts <see cref="Rgb" /> to its CSS representation
    /// </summary>
    /// <param name="rgb">
    /// The input RGB context
    /// </param>
    /// <returns>
    /// Exactly what <see cref="Rgb" /> would look like in CSS.
    /// Example: <br />
    /// <c>new Rgb(158, 234, 42)</c>
    /// <br />Returned string:<br />
    /// <c>rgb(158, 234, 42)</c>
    /// </returns>
    public static string ToCssRgb(this Rgb rgb)
        => $"rgb({rgb.Red}, {rgb.Green}, {rgb.Blue})";
}
