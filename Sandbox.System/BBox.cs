using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BBox
{
    public Vector3 Center { get; }
    public Vector3 Size { get; }
    public float Volume { get; }
    public Vector3 Mins { get; }
    public Vector3 Maxs { get; }

    public BBox(Vector3 min, Vector3 max)
    {

    }
}
