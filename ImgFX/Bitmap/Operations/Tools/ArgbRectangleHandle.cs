using ImgFX.Argb;
using ImgFX.Png;
using System.Text;

namespace ImgFX.Bitmap.Operations.Tools;

/// <summary>
/// Represents a rectangle of the image. It
/// also represents selected pixels within the
/// range of the rectangle.
/// </summary>
public class ArgbRectangleHandle
{
    private readonly ushort _xstart;
    private readonly ushort _ystart;

    private readonly ushort _xend;
    private readonly ushort _yend;

    private readonly List<List<Argb.Argb>> _initialPixels;
    private readonly List<List<Argb.Argb>> _modifiedPixels;

    public ArgbRectangleHandle(ushort xstart, ushort ystart, ushort xend, ushort yend, List<List<Argb.Argb>> initialPixels, List<List<Argb.Argb>>? modifiedPixels = null)
    {
        _xstart = xstart;
        _ystart = ystart;
        _xend = xend;
        _yend = yend;
        _initialPixels = initialPixels;
        _modifiedPixels = modifiedPixels ?? _initialPixels;
    }

    /// <summary>
    /// Start of X where this rectangle starts
    /// </summary>
    public ushort XStart
    {
        get
        {
            return _xstart;
        }
    }

    /// <summary>
    /// Start of Y where this rectangle starts
    /// </summary>
    public ushort YStart
    {
        get
        {
            return _ystart;
        }
    }

    /// <summary>
    /// End of X where this rectangle ends
    /// </summary>
    public ushort XEnd
    {
        get
        {
            return _xend;
        }
    }

    /// <summary>
    /// End of Y where this rectangle ends
    /// </summary>
    public ushort YEnd
    {
        get
        {
            return _yend;
        }
    }

    /// <summary>
    /// Height of this rectangle
    /// </summary>
    public ushort Height
    {
        get
        {
            return (ushort)(YStart - YEnd);
        }
    }

    /// <summary>
    /// Width of this rectangle
    /// </summary>
    public ushort Width
    {
        get
        {
            return (ushort)(XStart - XEnd);
        }
    }

    /// <summary>
    /// Selected pixels without any modification.
    /// <b>
    /// It is the best practice not to manually
    /// write to this property. Otherwise, initial
    /// pixels may no longer be known without
    /// re-processing the rectangle.
    /// </b>
    /// </summary>
    public List<List<Argb.Argb>> InitialPixels
    {
        get
        {
            return _initialPixels;
        }
    }

    /// <summary>
    /// Selected pixels. This also includes any
    /// modifications, like written pixels.
    /// </summary>
    public List<List<Argb.Argb>> ModifiedPixels
    {
        get
        {
            return _modifiedPixels;
        }
    }

    /// <summary>
    /// Fills the entire rectangle with a color
    /// </summary>
    public void Fill(Argb.Argb color)
    {
        for (int y = 0; y < ModifiedPixels.Count; y++)
        {
            for (int x = 0; x < ModifiedPixels[y].Count; x++)
            {
                ModifiedPixels[y][x] = color;
            }
        }
    }

    /// <summary>
    /// Sets the pixel at x, y
    /// </summary>
    /// <param name="x">X coordinate</param>
    /// <param name="y">Y coordinate</param>
    /// <param name="color">Color that will be set on the pixel</param>
    public void SetAt(ushort x, ushort y, Argb.Argb color)
    {
        _modifiedPixels[y][x] = color;
    }

    /// <summary>
    /// Stringifies <see cref="ArgbRectangleHandle" />. Returned
    /// data might be a nonsense, but it can be visualized by
    /// pasting it to a web-based processor, e.g. ImgFXView.
    /// </summary>
    public override string ToString()
    {
        StringBuilder sb = new();

        for (int y = 0; y < _modifiedPixels.Count; y++)
        {
            for (int x = 0; x < _modifiedPixels[y].Count; x++)
            {
                if (x != Width - 1)
                {
                    sb.Append($"{_modifiedPixels[y][x].ToCssRgba()};");
                }
                else
                {
                    sb.Append($"{_modifiedPixels[y][x].ToCssRgba()}\n");
                }
            }
        }

        return sb.ToString();
    }
}
