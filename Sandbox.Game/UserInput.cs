using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class UserInput
    {
        public virtual float Forward { get; }
        public virtual float Left { get; }
        public virtual Rotation Rot { get; }

        public abstract bool Down(InputButton button);

        public abstract bool Pressed(InputButton button);
    }
}
