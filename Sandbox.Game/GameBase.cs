using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class GameBase
    {
        public static GameBase Current { get; }

        public GameBase()
        {
            throw new NotImplementedException();
        }

        public virtual void OutputPlayerVoice(Player player, Player other, byte[] data)
        {
            throw new NotImplementedException();
        }

        public abstract void PlayerKilled(Player player);

        public abstract void PlayerRespawn(Player player);

        public abstract Player CreatePlayer();

        public abstract void PlayerJoined(Player player);

        public abstract void PlayerDisconnected(Player player, NetworkDisconnectionReason reason);

        public abstract void PlayerVoiceIn(Player speaker, byte[] voiceData);

        public abstract void PlayerVoiceOut(Player speaker, byte[] voiceData);

        public abstract Camera GetActiveCamera();

        public abstract void OnInput(ClientInput input);

        public abstract void PostCameraSetup(Camera camera);

        public abstract void PostLevelLoaded();
    }
}
