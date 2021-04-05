using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rotation
{
    public Vector3 Backward { get; }
    public Vector3 Forward { get; }
    public Rotation Inverse { get; }
    public Vector3 Left { get; }
    public Vector3 Right { get; }
    public Vector3 Up { get; }
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public float pitch { get; set; }
    public float yaw { get; set; }
    public float roll { get; set; }

    public Angles Angles()
    {
        throw new NotImplementedException();
    }

    public Rotation Clamp(Rotation rotation, float a, out float b)
    {
        throw new NotImplementedException();
    }

    public static Rotation Difference(Rotation a, Rotation b)
    {
        throw new NotImplementedException();
    }

    public static Rotation From(Angles angles)
    {
        throw new NotImplementedException();
    }

    public static Rotation FromAxis(Vector3 pos, float a)
    {
        throw new NotImplementedException();
    }

    public static Rotation Lerp(Rotation from, Rotation to, float a, bool b = false)
    {
        throw new NotImplementedException();
    }

    public static Rotation LookAt(Vector3 pos)
    {
        throw new NotImplementedException();
    }

    public static Rotation LookAt(Vector3 origin, Vector3 pos)
    {
        throw new NotImplementedException();
    }

    public static Rotation operator*(Rotation a, Rotation b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator*(Rotation a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static Rotation operator+(Rotation a, Rotation b)
    {
        throw new NotImplementedException();
    }
    
    public static Rotation operator-(Rotation a, Rotation b)
    {
        throw new NotImplementedException();
    }

    public static Rotation Slerp(Rotation from, Rotation to, float a, float b = false)
    {
        throw new NotImplementedException();
    }
}
