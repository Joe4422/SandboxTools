using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class ClientInput : UserInput
    {
        public bool StopProcessing { get; set; }
        public bool UsingMouse { get; }
        public Rotation AnalogLook { get; set; }
        public Rotation ViewAngles { get; set; }
        public Vector3 AnalogMove { get; set; }
        public Vector3 InputDirection { get; set; }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        public override bool Down(InputButton button)
        {
            throw new NotImplementedException();
        }
        public override bool Pressed(InputButton button)
        {
            throw new NotImplementedException();
        }
    }
}
