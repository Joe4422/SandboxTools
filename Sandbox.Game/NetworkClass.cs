using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class NetworkClass
    {
        public NetworkClass()
        {
            throw new NotImplementedException();
        }

        public virtual bool NetRead(NetRead netRead)
        {
            throw new NotImplementedException();
        }
        
        public virtual bool NetWrite(NetWrite netWrite)
        {
            throw new NotImplementedException();
        }

        public virtual void NetworkDirty(string id, NetVarGroup group)
        {
            throw new NotImplementedException();
        }
    }
}
