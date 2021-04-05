using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Asset
    {
        public string Path { get; }

        protected abstract void PostLoad();
    }
}
