using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class ModelEntity : Entity
    {
        public virtual int BoneCount { get; }
        public virtual BBox OOBBox { get; }
        public virtual PhysicsBody PhysicsBody { get; }
        public virtual float RenderAlpha { get; set; }
        public virtual CollisionGroup CollisionGroup { get; set; }
        public virtual bool EnableAllCollisions { get; set; }
        public virtual bool EnableSolidCollisions { get; set; }
        public virtual bool EnableTouch { get; set; }
        public virtual bool EnableTouchPersists { get; set; }
        public virtual bool PhysicsEnabled { get; set; }
        public virtual string SceneLayer { get; set; }
        public bool UsePhysicsCollision { get; set; }

        public abstract Transform GetAttachment(string id, bool a);

        public abstract string GetBoneName(int index);

        public abstract int GetBoneParent(int index);

        public abstract PhysicsBody GetBonePhysicsBody(int index);

        public abstract Transform GetBoneTransform(int index, bool a = default);

        public abstract Model GetModel();

        public virtual void OnNewModel(Model newModel)
        {
            throw new NotImplementedException();
        }

        public abstract void SetBoneTransform(int index, Transform transform, bool a = default);

        public abstract void SetInteractsAs(CollisionLayer layer);

        public abstract void SetModel(Model model);

        public abstract void SetModel(string path);

        public abstract PhysicsGroup SetupPhysicsFromAABB(PhysicsMotionType motion, Vector3 min, Vector3 max);

        public abstract void SetupPhysicsFromModel(PhysicsMotionType motion, bool a = default);

        protected abstract void OnRemove();

        public abstract void ClearCollisionLayers();

        public abstract void AddCollisionLayer(CollisionLayer layer);

        public abstract Transform[] ComputeBones(float a);
    }
}
