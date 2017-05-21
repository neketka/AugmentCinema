using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace AugmentCinemaBackend
{
    public struct ShaderPass
    {
        public ShaderPass(ShaderProgram program, PrimitiveType type)
        {
            this.program = program;
            this.type = type;
            this.commands = new List<Action>();
            this.unitCounter = 0;
            this.indices = null;
            this.framebuffer = FBO.DeviceFramebuffer;
        }

        public void SetAttributeVBO<T>(string attribname, VBO<T> vbo) where T : struct
        {
            int attribloc = GL.GetAttribLocation(program.ProgramId, attribname);
            Type t = typeof(T);
            vbo.Bind(); //Bind the VBO to context
            GL.EnableVertexAttribArray(attribloc); //Enable the attribute
            GL.VertexAttribPointer(attribloc, vbo.AttribSize, VertexAttribPointerType.Float, false, 0, 0); //Bind VBO to attribute
        }

        public void SetIndexBuffer(VBO<int> indices)
        {
            this.indices = indices;
        }

        public void SetFramebuffer(FBO fbo)
        {
            this.framebuffer = fbo;
        }

        public void RunPass()
        {
            program.Bind();
            framebuffer.Bind();
            commands.ForEach((c) => c());
            indices.Bind();
            GL.DrawElements(type, indices.Length, DrawElementsType.UnsignedInt, IntPtr.Zero); //Draw the object
        }

        #region Uniform Properties
        public void SetUniform(string name, int value) //Sets the value for a uniform variable
        {
            int index = GL.GetUniformLocation(program.ProgramId, name); //Get the location of the variable
            //Log and throw an exception if variable doesn't exist
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform1(index, value)); //Set the uniform value
        }

        public void SetUniform(string name, float value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform1(index, value));
        }

        public void SetUniform(string name, double value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform1(index, value));
        }

        public void SetUniform(string name, Vector2 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform2(index, value));
        }

        public void SetUniform(string name, Vector3 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform3(index, value));
        }

        public void SetUniform(string name, Vector4 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => GL.Uniform4(index, value));
        }

        public void SetUniform(string name, Matrix2 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => { Matrix2 v = value; GL.UniformMatrix2(index, false, ref v); });
        }

        public void SetUniform(string name, Matrix3 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable!"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => { Matrix3 v = value; GL.UniformMatrix3(index, false, ref v); });
        }

        public void SetUniform(string name, Matrix4 value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 0) { Console.WriteLine("Attempt to use undefined uniform variable"); throw new Exception("Uniform variable not found!"); }
            commands.Add(() => { Matrix4 v = value; GL.UniformMatrix4(index, false, ref v); });
        }

        public void SetUniform(string name, Texture2D value)
        {
            int index = GL.GetUniformLocation(program.ProgramId, name);
            if (index < 1) { Console.WriteLine("Attempt to use undefined uniform variable"); throw new Exception("Uniform variable not found!"); }
            int unitCounter = this.unitCounter;
            commands.Add(() => {
                GL.Uniform1(index, unitCounter);
                value.Bind(unitCounter);
            });
            unitCounter++;
        }
        #endregion

        private ShaderProgram program;
        private PrimitiveType type;
        private int unitCounter;
        private List<Action> commands;
        private VBO<int> indices;
        private FBO framebuffer;
    }
}