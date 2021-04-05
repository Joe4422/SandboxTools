using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class Host
    {
        public static bool IsClient { get; }
        public static bool IsServer { get; }
        
        public static void AssertClient()
        {
            throw new NotImplementedException();
        }

        public static void AssertServer()
        {
            throw new NotImplementedException();
        }
    }
}
