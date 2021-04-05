using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Angles
{
    public Vector3 Direction { get; }
    public float Length { get; }
    public Angles Normal { get; }

    public static Angles Zero { get; }

    public float pitch { get; set; }
    public float yaw { get; set; }
    public float roll { get; set; }

    public Angles(float pitch, float yaw, float roll)
    {
        throw new NotImplementedException();
    }

    public static Angles operator+(Angles a, Angles b)
    {
        throw new NotImplementedException();
    }

    public static Angles operator*(Angles a, float b)
    {
        throw new NotImplementedException();
    }

    public static Angles operator-(Angles a, Angles b)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Rotation(Angles angles)
    {
        throw new NotImplementedException();
    }
}