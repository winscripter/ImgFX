using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgFX.Fonts;

public static class FontContextExtensions
{
    public static FontTextTable? By(this FontContext context, ushort @char, int percentage)
    {
        foreach (var table in context.Table)
        {
            if (table.UnicodeNumber == @char && table.Percentage == percentage)
            {
                return table;
            }
        }

        return null;
    }

    public static FontTextTable? By(this FontContext context, ushort @char, ushort height, ushort width)
    {
        foreach (var table in context.Table)
        {
            if (table.Height == height && table.Width == width && table.UnicodeNumber == @char)
            {
                return table;
            }
        }

        return null;
    }
}
