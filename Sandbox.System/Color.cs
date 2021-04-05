using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Color
{
    public static Color Red { get; }
    public static Color Yellow { get; }
    public static Color White { get; }
    public static Color Green { get; }
    public static Color Blue { get; }

    public static Color FromBytes(int r, int g, int b, int a = 255)
    {
        throw new NotImplementedException();
    }

    public static Color Lerp(Color from, Color to, float progress)
    {
        throw new NotImplementedException();
    }

    public Color WithAlpha(float alpha)
    {
        throw new NotImplementedException();
    }
}
