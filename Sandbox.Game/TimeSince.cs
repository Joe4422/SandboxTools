using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class TimeSince
    {
        public static implicit operator float(TimeSince ts)
        {
            throw new NotImplementedException();
        }

        public static implicit operator TimeSince(float f)
        {
            throw new NotImplementedException();
        }
    }
}
