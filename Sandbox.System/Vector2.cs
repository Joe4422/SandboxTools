using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector2
{
    public float x { get; set; }
    public float y { get; set; }

    public Vector2(float x, float y)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Vector2(Vector3 value)
    {
        throw new NotImplementedException();
    }

    public static Vector2 operator-(Vector2 a, Vector2 b)
    {
        throw new NotImplementedException();
    }
}
