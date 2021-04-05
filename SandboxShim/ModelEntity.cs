using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class ModelEntity : Entity
    {
        public virtual PhysicsBody PhysicsBody { get; set; }

        public virtual Model GetModel()
        {
            throw new NotImplementedException();
        }

        public virtual void SetModel(Model mdl)
        {
            throw new NotImplementedException();
        }
    }
}
