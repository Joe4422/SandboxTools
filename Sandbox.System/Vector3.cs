using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector3
{
    public float Length { get; }
    public float LengthSquared { get; }
    public Vector3 Normal { get; }
    public static Vector3 Random { get; }
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public static Vector3 Forward { get; }
    public static Vector3 Up { get; }
    public static Vector3 Right { get; }
    public static Vector3 Down { get; }
    public static Vector3 Backward { get; }
    public static Vector3 Left { get; }

    public static Vector3 Zero { get; }
    public static Vector3 One { get; }

    public Vector3(float x, float y)
    {
        throw new NotImplementedException();
    }

    public Vector3(float x, float y, float z)
    {
        throw new NotImplementedException();
    }

    public Vector3 Approach(float a, float b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public float Distance(Vector3 other)
    {
        throw new NotImplementedException();
    }

    public float Dot(Vector3 other)
    {
        throw new NotImplementedException();
    }

    public static float Dot(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 Lerp(Vector3 pos, Vector3 targetPos, float a, bool b = false)
    {
        throw new NotImplementedException();
    }

    public Vector3 LerpTo(Vector3 targetPos, float a, bool b = false)
    {
        throw new NotImplementedException();
    }

    public Vector3 SubtractDirection(Vector3 other)
    {
        throw new NotImplementedException();
    }

    public Vector3 WithZ(float z)
    {
        throw new NotImplementedException();
    }

    public static float DistanceBetween(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static bool operator ==(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static bool operator !=(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator*(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Vector3(float f)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator*(Vector3 a, Rotation b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator*(Vector3 a, float b)
    {
        throw new NotImplementedException();
    }

    public static Vector3 operator-(Vector3 a, Vector3 b)
    {
        throw new NotImplementedException();
    }

}
