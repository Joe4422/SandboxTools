using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Entity
    {
        public virtual Vector3 WorldPos { get; set; }
        public virtual Rotation WorldRot { get; set; }
        public abstract void Spawn();
    }
}
