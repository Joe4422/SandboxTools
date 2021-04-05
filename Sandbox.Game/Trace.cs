using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Trace
    {
        public Trace HitLayer(CollisionLayer layer, bool a)
        {
            throw new NotImplementedException();
        }

        public Trace Ignore(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Trace Radius(float radius)
        {
            throw new NotImplementedException();
        }

        public static Trace Ray(Vector3 start, Vector3 end)
        {
            throw new NotImplementedException();
        }

        public TraceResult Run()
        {
            throw new NotImplementedException();
        }

        public Trace Size(Vector3 size)
        {
            throw new NotImplementedException();
        }

        public Trace Size(Vector3 a, Vector3 b)
        {
            throw new NotImplementedException();
        }

        public Trace UseHitboxes(bool useHitboxes = true)
        {
            throw new NotImplementedException();
        }

        public Trace WorldOnly()
        {
            throw new NotImplementedException();
        }
    }
}
