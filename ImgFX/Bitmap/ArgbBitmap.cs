namespace ImgFX.Bitmap;

/// <summary>
/// Represents a grid of pixels.<br />
/// In simple terms, it's an image.<br /><br />
/// 
/// <see cref="ArgbBitmap" /> consists of RGBA pixels only. Use
/// <see cref="Bitmap" /> for a bitmap that consists of RGB
/// pixels.
/// </summary>
public class ArgbBitmap : IArgbBitmap
{
    private readonly ushort _x;
    private readonly ushort _y;

    private readonly List<List<Argb.Argb>> _image;

    public ArgbBitmap(ushort x, ushort y)
    {
        _x = x;
        _y = y;

        _image = new List<List<Argb.Argb>>();
        FillWith(new Argb.Argb(0, 0, 0, 10)); // black
    }

    public ArgbBitmap(ushort x, ushort y, List<List<Argb.Argb>> image)
        : this(x, y)
    {
        _image = image;
    }

    /// <inheritdoc />
    public void FillWith(Argb.Argb color)
    {
        for (int y = 0; y < _image.Count; y++)
        {
            for (int x = 0; x < _image[y].Count; x++)
            {
                _image[y][x] = color;
            }
        }
    }

    /// <inheritdoc />
    public void SetAt(ushort x, ushort y, Argb.Argb color)
        => _image[y][x] = color;

    /// <inheritdoc />
    public List<List<Argb.Argb>> Frame
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
