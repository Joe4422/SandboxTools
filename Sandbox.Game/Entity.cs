using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sandbox.Internal;

namespace Sandbox
{
    public abstract class Entity
    {
        public virtual Entity ActiveChild { get; set; }
        public static List<Entity> All { get; }
        public string EngineEntityName { get; }
        public bool HasLocalPlayerOwner { get; }
        public int Health { get; set; }
        public bool IsClient { get; }
        public bool IsClientOnly { get; }
        public bool IsFirstPersonMode { get; }
        public bool IsServer { get; }
        public bool IsWorld { get; }
        public Entity LastAttacker { get; }
        public LifeState LifeState { get; set; }
        public Player Owner { get; set; }
        public Entity Parent { get; set; }
        public PhysicsGroup PhysicsGroup { get; }
        public Vector3 Pos { get; set; }
        public Rotation Rot { get; set; }
        public Transform Transform { get; set; }
        public Vector3 Velocity { get; set; }
        public Vector3 WorldPos { get; set; }
        public Rotation WorldRot { get; set; }
        public bool EnableDrawing { get; set; }
        public bool EnableHideInFirstPerson { get; set; }
        public bool EnableShadowInFirstPerson { get; set; }
        public bool EnableViewmodelRendering { get; set; }
        public MoveType MoveType { get; set; }
        public Entity OwnerEntity { get; set; }
        public TransmitType Transmit { get; set; }
        public SpawnFlagAccessor SpawnFlags { get; }
        public TaskSource Task { get; }
        public WaterLevel WaterLevel { get; }
        public int NetworkIdent { get; }

        public Entity()
        {
            throw new NotImplementedException();
        }

        public virtual void ActiveEnd(Entity ent, bool dropped)
        {
            throw new NotImplementedException();
        }

        public virtual void ActiveStart(Entity ent)
        {
            throw new NotImplementedException();
        }

        public static T Create<T>()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }

        public virtual void EndTouch(Entity other)
        {
            throw new NotImplementedException();
        }

        public virtual void FireOutput(string output, Entity user, object target, float a = default)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDestroy()
        {
            throw new NotImplementedException();
        }

        public virtual void OnKilled()
        {
            throw new NotImplementedException();
        }

        public virtual Sound PlaySound(string sound)
        {
            throw new NotImplementedException();
        }

        public virtual void ResetInterpolation()
        {
            throw new NotImplementedException();
        }

        public virtual void SetParent(Entity entity, bool a = default)
        {
            throw new NotImplementedException();
        }

        public virtual void SetParent(Entity entity, string a, Transform? transform)
        {
            throw new NotImplementedException();
        }

        public virtual void Spawn()
        {
            throw new NotImplementedException();
        }

        public virtual void StartTouch(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void TakeDamage(DamageInfo info)
        {
            throw new NotImplementedException();
        }

        public virtual void Touch(Entity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void MoveFinished()
        {
            throw new NotImplementedException();
        }
    }
}
