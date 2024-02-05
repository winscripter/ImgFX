namespace ImgFX.Bitmap;

/// <summary>
/// Represents a grid of pixels.<br />
/// In simple terms, it's an image.<br /><br />
/// 
/// <see cref="Bitmap" /> consists of RGB pixels only. Use
/// <see cref="ArgbBitmap" /> for a bitmap that consists of RGBA
/// pixels.
/// </summary>
public class Bitmap : IRgbBitmap
{
    private readonly ushort _x;
    private readonly ushort _y;

    private readonly List<List<Rgb.Rgb>> _image;

    public Bitmap(ushort x, ushort y)
    {
        _x = x;
        _y = y;

        _image = new List<List<Rgb.Rgb>>();
        FillWith(new Rgb.Rgb(0, 0, 0)); // black
    }

    public Bitmap(ushort x, ushort y, List<List<Rgb.Rgb>> image)
        : this(x, y)
    {
        _image = image;
    }

    /// <inheritdoc />
    public void FillWith(Rgb.Rgb color)
    {
        for (int y = 0; y < _y; y++)
        {
            for (int x = 0; x < _x; x++)
            {
                _image[y][x] = color;
            }
        }
    }

    /// <inheritdoc />
    public void SetAt(ushort x, ushort y, Rgb.Rgb color)
        => _image[y][x] = color;

    /// <inheritdoc />
    public List<List<Rgb.Rgb>> Frame
    {
        get
        {
            return _image;
        }
    }

    /// <inheritdoc />
    public ushort X
    {
        get
        {
            return _x;
        }
    }

    /// <inheritdoc />
    public ushort Y
    {
        get
        {
            return _y;
        }
    }
}
