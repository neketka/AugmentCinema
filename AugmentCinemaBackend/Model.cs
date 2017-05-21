using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace AugmentCinemaBackend
{
    public class Model
    {
        public static void Init()
        {
            program = new ShaderProgram(VShader, FShader);
        }

        private VBO<Vector3> vbuffer;
        private VBO<Vector2> uvbuffer;
        private VBO<int> ibuffer;
        private Texture2D texture;
        private ShaderPass shaderPass;
        public Model(Vector3[] vertices, Vector2[] texcoords, Texture2D texture)
        {
            vbuffer = new VBO<Vector3>(vertices, false);
            uvbuffer = new VBO<Vector2>(texcoords, false);
            ibuffer = new VBO<int>(Enumerable.Range(0, vertices.Count()).ToArray(), true);
            this.texture = texture;
            shaderPass = new ShaderPass(program, OpenTK.Graphics.OpenGL.PrimitiveType.Triangles);
            shaderPass.SetAttributeVBO("vertex", vbuffer);
            shaderPass.SetAttributeVBO("texcoord", uvbuffer);
            shaderPass.SetIndexBuffer(ibuffer);
            shaderPass.SetUniform("sTexture", texture);
        }

        public void Render(FBO f, int w, int h, Matrix4 camera, Matrix4 model)
        {
            shaderPass.SetFramebuffer(f);
            shaderPass.SetUniform("projection", Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90f), 
                (float)w / (float)h, 0.3f, 1000f));
            shaderPass.SetUniform("camera", camera);
            shaderPass.SetUniform("model", model);
            shaderPass.RunPass();
        }

        static string VShader = @"
            out vec2 interpTex;
            in vec3 vertex;
            in vec2 texcoord;
            uniform mat4 projection;
            uniform mat4 camera;
            uniform mat4 model;
            void main()
            {
                interpTex = texcoord;
                gl_Vertex = vec4(vertex, 1) * projection * camera * matrix;
            } 
        ";
        static string FShader = @"
            out vec4 fragment;
            in vec2 interpTex;
            uniform sampler2D sTexture;
            void main()
            {
                fragment = texture(sTexture, interpTex);
            }
        ";
        static ShaderProgram program;
    }
}
