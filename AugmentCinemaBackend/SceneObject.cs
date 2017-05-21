using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace AugmentCinemaBackend
{
    public class SceneObject
    {
        private Model model;
        public Matrix4 Transform;
        public SceneObject(Model model)
        {
            this.model = model;
        }

        public void Render(FBO fbo, Matrix4 camera)
        {
            model.Render(fbo, 1, camera, Transform);
        }
    }
}
