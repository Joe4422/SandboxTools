using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class RealTimeSince
    {
        public static implicit operator float(RealTimeSince ts)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RealTimeSince(float f)
        {
            throw new NotImplementedException();
        }
    }
}
