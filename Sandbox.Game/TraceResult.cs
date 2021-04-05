using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class TraceResult
    {
        public Vector3 Normal { get; }
        public int Bone { get; }
        public Vector3 EndPos { get; set; }
        public Entity Entity { get; }
        public Surface Surface { get; }
        public bool Hit { get; }
        public Vector3 Direction { get; }
        public float Fraction { get; }
        public bool StartedSolid { get; }
    }
}
