using ImgFX.Bitmap.Operations.Tools;

namespace ImgFX.Bitmap.Operations;

public class ArgbBitmapOperations
{
    private readonly ArgbBitmap _bitmap;

    public ArgbBitmapOperations(ArgbBitmap bitmap)
    {
        _bitmap = bitmap;
    }

    public void DrawStraightLineX(ushort y, ushort xstart, ushort xend, Argb.Argb color)
    {
        for (int i = xstart; i < xend; i++)
        {
            _bitmap.Frame[y][i] = color;
        }
    }

    public void DrawStraightLineY(ushort x, ushort ystart, ushort yend, Argb.Argb color)
    {
        for (int i = ystart; i < yend; i++)
        {
            _bitmap.Frame[i][x] = color;
        }
    }

    public ArgbRectangleHandle GetRectangle(ushort startx, ushort starty, ushort endx, ushort endy)
    {
        List<List<Argb.Argb>> pixels = new();

        for (int y = starty; y < endy; y++)
        {
            var line = new List<Argb.Argb>();
            for (int x = startx; x < endx; x++)
            {
                line.Add(_bitmap.Frame[y][x]);
            }

            pixels.Add(line);
        }

        return new ArgbRectangleHandle(
            startx,
            starty,
            endx,
            endy,
            pixels,
            pixels
        );
    }
}
