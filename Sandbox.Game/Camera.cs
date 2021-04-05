using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Camera
    {
        public virtual float DoFBlurSize { get; set; }
        public virtual float DoFPoint { get; set; }
        public virtual float FieldOfView { get; set; }
        public virtual float LastFieldOfView { get; set; }
        public virtual Vector3 LastPos { get; }
        public virtual Rotation LastRot { get; }
        public virtual Vector3 Pos { get; set; }
        public virtual Rotation Rot { get; set; }
        public virtual Entity Viewer { get; set; }
        public virtual float ViewModelFieldOfView { get; set; }

        public Camera()
        {
        }

        public abstract void BuildInput(ClientInput input);

        public abstract void Activated();

        public abstract void Deactivated();

        public abstract void Update();
    }
}
