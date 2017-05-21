using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace AugmentCinemaBackend
{
    public class AugmentCinema
    {
        public Scene Scene;
        public List<SceneObject> Objects;
        public AugmentCinema()
        {
        }

        public void Tick()
        {
            Scene.CaptureFrame();
            Matrix4 matrix = Scene.GetTransform();
        }
    }
}
