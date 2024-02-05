namespace ImgFX.Bitmap;

public interface IArgbBitmap
{
    /// <summary>
    /// Represents width of the bitmap
    /// </summary>
    ushort X { get; }

    /// <summary>
    /// Represents height of the bitmap
    /// </summary>
    ushort Y { get; }

    /// <summary>
    /// Represents pixels in this bitmap
    /// </summary>
    List<List<Argb.Argb>> Frame { get; }

    /// <summary>
    /// Fills the frame with the specified color
    /// </summary>
    /// <param name="color">
    /// Color to fill the bitmap with
    /// </param>
    void FillWith(Argb.Argb color);

    /// <summary>
    /// Sets the pixel at x, y with color
    /// </summary>
    /// <param name="x">Width</param>
    /// <param name="y">Height</param>
    /// <param name="color">Color</param>
    void SetAt(ushort x, ushort y, Argb.Argb color);
}
