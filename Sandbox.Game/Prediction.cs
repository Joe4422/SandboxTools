using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Prediction : IDisposable
    {
        public static bool FirstTime { get; }

        public static Prediction Off()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            throw new NotImplementedException();
        }
    }
}
