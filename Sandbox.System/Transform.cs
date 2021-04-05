using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Transform
{
    public Vector3 Pos { get; set; }
    public Rotation Rot { get; set; }

    public Transform Add(Vector3 pos, bool a)
    {
        throw new NotImplementedException();
    }

    public Transform Lerp(Transform from, Transform to, float a, bool b = default)
    {
        throw new NotImplementedException();
    }

    public Vector3 NormalToWorld(Vector3 normal)
    {
        throw new NotImplementedException();
    }

    public Vector3 PointToLocal(Vector3 point)
    {
        throw new NotImplementedException();
    }

    public Vector3 PointToWorld(Vector3 point)
    {
        throw new NotImplementedException();
    }

    public Rotation RotationToLocal(Rotation rot)
    {
        throw new NotImplementedException();
    }

    public Rotation RotationToWorld(Rotation rot)
    {
        throw new NotImplementedException();
    }

    public Vector3 TransformVector(Vector3 vector)
    {
        throw new NotImplementedException();
    }
}
