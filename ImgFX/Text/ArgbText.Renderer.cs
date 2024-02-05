using ImgFX.Fonts;

namespace ImgFX.Text;

public partial class ArgbText
{
    /// <summary>
    /// Begins adding text to an image
    /// </summary>
    public void Render()
    {
        ushort x = 0;
        ushort y = 0;

        foreach (char c in Text)
        {
            var representation = _font.By(c, FontSize);

            var grid = ToGrid(representation!.Grid, representation!.Height, representation!.Width);

            for (ushort y2 = 0; y2 < representation.Height; y2++)
            {
                for (ushort x2 = 0; x2 < representation.Width; x2++)
                {
                    if (grid[y2][x2])
                    {
                        RectangleSelection.SetAt((ushort)(x2 + x), (ushort)(y2 + y), ForegroundColor);
                    }
                    else
                    {
                        if (BackgroundColor != null)
                        {
                            RectangleSelection.SetAt((ushort)(x2 + x), (ushort)(y2 + y), BackgroundColor);
                        }
                    }
                }
            }

            x += (ushort)(representation.Width + LetterSpacing);
            y += (ushort)(representation.Height + LetterSpacing);
        }
    }

    private static List<List<bool>> ToGrid(bool[] grid, int sizeX, int sizeY)
    {
        List<List<bool>> pixels = new();

        for (int y = 0; y < sizeY; y++)
        {
            List<bool> p = new();

            for (int x = 0; x < sizeX; x++)
            {
                p.Add(grid[y + x]);
            }

            pixels.Add(p);
        }

        return pixels;
    }
}
