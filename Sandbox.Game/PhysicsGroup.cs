using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class PhysicsGroup
    {
        public int BodyCount { get; }
        public Vector3 MassCenter { get; }

        public PhysicsBody GetBody(int index)
        {
            throw new NotImplementedException();
        }

        public void SetSurface(string surface)
        {
            throw new NotImplementedException();
        }
    }
}
