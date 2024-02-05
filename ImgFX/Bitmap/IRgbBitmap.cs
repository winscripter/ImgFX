namespace ImgFX.Bitmap;

public interface IRgbBitmap
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
    List<List<Rgb.Rgb>> Frame { get; }

    /// <summary>
    /// Fills the frame with the specified color
    /// </summary>
    /// <param name="color">
    /// Color to fill the bitmap with
    /// </param>
    void FillWith(Rgb.Rgb color);

    /// <summary>
    /// Sets the pixel at x, y with color
    /// </summary>
    /// <param name="x">Width</param>
    /// <param name="y">Height</param>
    /// <param name="color">Color</param>
    void SetAt(ushort x, ushort y, Rgb.Rgb color);
}
