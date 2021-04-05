using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class PlayerAnimator
    {
        public virtual Entity GroundEntity { get; set; }
        public virtual ClientInput Input { get; }
        public virtual Player Player { get; }
        public virtual Rotation Rot { get; set; }
        public virtual Vector3 WishVelocity { get; set; }

        public PlayerAnimator()
        {
        }

        public virtual void BuildInput(ClientInput input)
        {
            throw new NotImplementedException();
        }

        public virtual bool HasTag(string tag)
        {
            throw new NotImplementedException();
        }

        public virtual void OnEvent(string evt)
        {
            throw new NotImplementedException();
        }

        public virtual void SetLookAt(string id, Vector3 pos)
        {
            throw new NotImplementedException();
        }

        public virtual void SetParam(string id, bool param)
        {
            throw new NotImplementedException();
        }

        public virtual void SetParam(string id, int param)
        {
            throw new NotImplementedException();
        }

        public virtual void SetParam(string id, float param)
        {
            throw new NotImplementedException();
        }

        public virtual void Trigger(string id)
        {
            throw new NotImplementedException();
        }

        public abstract void Tick();
    }
}
