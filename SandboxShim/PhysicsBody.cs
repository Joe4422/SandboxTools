using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class PhysicsBody
    {
        public float AngularDrag { get; set; }
        public Vector3 AngularVelocity { get; set; }
        public float GravityScale { get; set; }
        public float LinearDrag { get; set; }
        public PhysicsBody Parent { get; set; }
        public Vector3 Velocity { get; set; }
        public Vector3 Pos { get; }
        public float Density { get; }
        public Vector3 LocalMassCenter { get; }
        public int ShapeCount { get; }

        public Vector3 GetVelocityAtPoint(Vector3 point)
        {
            throw new NotImplementedException();
        }

        public void AddCloneShape(PhysicsShape shape)
        {
            throw new NotImplementedException();
        }

        public void ApplyForceAt(Vector3 pos, Vector3 velocity)
        {
            throw new NotImplementedException();
        }

        public void ApplyImpulseAt(Vector3 pos, Vector3 velocity)
        {
            throw new NotImplementedException();
        }

        public Vector3 FindClosestPoint(Vector3 pos)
        {
            throw new NotImplementedException();
        }

        public Vector3 
    }
}
