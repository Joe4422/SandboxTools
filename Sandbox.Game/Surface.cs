using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Surface
    {
        public class ImpactEffectData
        {
            public string[] Bullet { get; }
            public string[] BulletDecal { get; }
            public string[] Regular { get; }
        }

        public class SoundData
        {
            public string Bullet { get; }
            public string FootLeft { get; }
            public string FootRight { get; }
        }

        public float Friction { get; }
        public ImpactEffectData ImpactEffects { get; }
        public SoundData Sounds { get; }
    }
}
