namespace ImgFX.Argb;

/// <summary>
/// Extensions for <see cref="Argb" />
/// </summary>
public static class ArgbExtensions
{
    /// <summary>
    /// Converts <see cref="Argb" /> to its CSS representation with
    /// hexadecimal digits
    /// </summary>
    /// <param name="argb">
    /// The input RGBA context
    /// </param>
    /// <returns>
    /// Exactly what <see cref="Argb" /> would look like in CSS.
    /// Example: <br />
    /// <c>new Argb(0x7E, 0x4E, 0x98, 7)</c>
    /// <br />Returned string:<br />
    /// <c>rgba(0x7E, 0x4E, 0x98, 0.7)</c>
    /// </returns>
    public static string ToCssRgbaHex(this Argb argb)
        => $"rgba(0x{argb.Red:X2}, 0x{argb.Green:X2}, 0x{argb.Blue:X2}, {AlphaToDecimal(argb)})";

    /// <summary>
    /// Converts <see cref="Argb" /> to its CSS representation
    /// </summary>
    /// <param name="argb">
    /// The input RGBA context
    /// </param>
    /// <returns>
    /// Exactly what <see cref="Argb" /> would look like in CSS.
    /// Example: <br />
    /// <c>new Argb(123, 234, 56, 7)</c>
    /// <br />Returned string:<br />
    /// <c>rgba(123, 234, 56, 0.7)</c>
    /// </returns>
    public static string ToCssRgba(this Argb argb)
        => $"rgba({argb.Red}, {argb.Green}, {argb.Blue}, {AlphaToDecimal(argb)})";

    /// <summary>
    /// Converts RGBA alpha to <see cref="decimal" />
    /// </summary>
    /// <param name="argb">
    /// Input RGBA
    /// </param>
    /// <returns>
    /// <see cref="decimal"/> representation of given RGBA's alpha
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Alpha is not valid
    /// </exception>
    public static decimal AlphaToDecimal(this Argb argb)
    {
        return argb.Alpha / 10;
    }

    /// <summary>
    /// Converts given <see cref="decimal" /> to alpha,
    /// which is a byte. This alpha can then be passed
    /// to <see cref="Argb" />.
    /// </summary>
    /// <param name="f">
    /// Input alpha value as decimal. Must not
    /// be greater than 25.0 or less than 0.0,
    /// and must have a remainder which is 1
    /// digit long. Otherwise, you'll get a
    /// <see cref="ArgumentException"/>. ;)
    /// </param>
    /// <returns>
    /// <see cref="byte" /> representation of <see cref="decimal"/>
    /// alpha value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Parameter <c>f</c> is greater than 25.0, or
    /// less than 0.0, or remainder is more than 1
    /// digit long.
    /// </exception>
    public static byte DecimalToAlpha(decimal f)
    {
        if (f > 25.0M || f < 0.0M)
        {
            throw new ArgumentException("Decimal can't be converted to Alpha because its value is less than 0.0 or greater than 25.0");
        }

        if ((f % 1).ToString().Split('.')[1].Length > 1)
        {
            throw new ArgumentException("Length of decimal remainder must not be greater than 1");
        }

        return (byte)(f * 10);
    }
}
