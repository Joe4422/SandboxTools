using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Player : Entity
    {
        public static List<Player> All { get; }

        public virtual Vector3 EyePos { get; }
        public virtual Rotation EyeRot { get; }
        public virtual ClientInput Input { get; }
        public virtual bool IsLocalPlayer { get; }
        public virtual float LastVoiceTime { get; }
        public static Player Local { get; }
        public virtual string Name { get; }
        public virtual ulong SteamId { get; }
        public static bool VoiceHearSelf { get; }
        public virtual float VoiceLevel { get; }
        public virtual bool VoiceUsed { get; }
        public virtual bool VoiceRecord { get; set; }

        public Player()
        {
            throw new NotImplementedException();
        }

        public abstract void BuildInput(ClientInput input);

        public abstract PlayerAnimator GetActiveAnimator();

        public abstract Camera GetActiveCamera();

        public abstract PlayerController GetActiveController();

        public abstract T GetScore<T>(string id, T a = default);

        public abstract string GetUserString(string id);

        public abstract bool HasPermission(string id);

        public abstract void PlayVoice(byte[] data);

        public abstract void PostCameraSetup(Camera camera);

        public abstract void Respawn();

        public abstract void SendCommandToClient(string command);

        public abstract void SetScore(string id, object value);

        public abstract void UpdatePhysicsHull();

        protected abstract void Tick();

        public abstract void OnAnimEventFootstep(Vector3 pos, int foot, float volume);
    }
}
