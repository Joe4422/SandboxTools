using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class PlayerController
    {
        public virtual Vector3 BaseVelocity { get; set; }
        public virtual Entity GroundEntity { get; set; }
        public virtual ClientInput Input { get; }
        public virtual Player Player { get; }
        public virtual Vector3 Pos { get; set; }
        public virtual Vector3 ViewOffset { get; set; }
        public virtual Vector3 WishVelocity { get; set; }
        public virtual Vector3 GroundNormal { get; set; }
        public virtual Vector3 Velocity { get; set; }
        public virtual Rotation Rot { get; set; }

        public PlayerController()
        {
            throw new NotImplementedException();
        }

        public virtual void AddEvent(string evt)
        {
            throw new NotImplementedException();
        }

        public virtual void BuildInput(ClientInput owner)
        {
            throw new NotImplementedException();
        }

        public virtual void SetTag(string tag)
        {
            throw new NotImplementedException();
        }

        public abstract BBox GetHull();

        public abstract void Tick();
    }
}
