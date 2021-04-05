using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class CameraModifier
    {
        public CameraModifier()
        {
            throw new NotImplementedException();
        }

        public abstract bool Update(Camera cam);
    }
}
