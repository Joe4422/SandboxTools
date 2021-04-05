using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class NullChecks
    {
        public static bool IsValid(this Entity entity)
        {
            throw new NotImplementedException();
        }

        public static bool IsValid(this PhysicsBody body)
        {
            throw new NotImplementedException();
        }
    }
}
