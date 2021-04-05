using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class DamageInfo
    {
        public Entity Attacker { get; }
        public PhysicsBody Body { get; }
        public Vector3 Force { get; }
        public Vector3 Position { get; }

        public static DamageInfo Generic(float damage)
        {
            throw new NotImplementedException();
        }

        public DamageInfo WithAttacker(Entity attacker, Entity other = default)
        {
            throw new NotImplementedException();
        }
    }
}
