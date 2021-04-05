using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class DebugOverlay
    {
        public static void Axis(Vector3 pos, Rotation rot, float length /* maybe */, float a = default, bool depthTest = true)
        {
            throw new NotImplementedException();
        }

        public static void Box(float duration, Vector3 pos, Rotation rot, Vector3 min, Vector3 max, Color color, bool depthTest = true)
        {
            throw new NotImplementedException();
        }

        public static void Box(Vector3 pos, Vector3 min, Vector3 max, Color color, bool depthTest = true)
        {
            throw new NotImplementedException();
        }

        public static void Line(Vector3 start, Vector3 end, Color color, float width = 1.0f, bool depthTest = true)
        {
            throw new NotImplementedException();
        }

        public static void ScreenText(int lineOffset, string text, float duration = 0.0f)
        {
            throw new NotImplementedException();
        }

        public static void ScreenText(Vector2 pos, int lineOffset, Color color, string text, float duration = 0.0f)
        {
            throw new NotImplementedException();
        }

        public static void Text(Vector3 pos, string text, Color color, float size = 1.0f, float duration = 0.0f)
        {
            throw new NotImplementedException();
        }

        public static void Text(Vector3 pos, string text, float size = 1.0f)
        {
            throw new NotImplementedException();
        }
    }
}
