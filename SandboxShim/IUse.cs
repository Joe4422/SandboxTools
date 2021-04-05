using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public interface IUse
    {
        bool OnUse(Entity user);
    }
}
