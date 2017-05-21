using System;
using OpenTK.Graphics.OpenGL;

namespace AugmentCinemaBackend
{
    /*
     * A wrapper for all OpenGL shaders and shader programs
     * Must be disposed before the destructor is invoked
     */
    public class ShaderProgram : IDisposable
    {
        //The most commonly used constructor
        public ShaderProgram(string vertex, string fragment)
        {
            ProgramId = GL.CreateProgram(); //Create shader program handle

            int vid = GL.CreateShader(ShaderType.VertexShader); //Create shader object handle
            int fid = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(vid, vertex); //Input the shader source code
            GL.ShaderSource(fid, fragment);

            GL.CompileShader(vid); //Compile vertex shader
            string s = GL.GetShaderInfoLog(vid);
            Console.WriteLine(GL.GetShaderInfoLog(vid)); //Log the shader info log
            int vstatus; GL.GetShader(vid, ShaderParameter.CompileStatus, out vstatus);
            if (vstatus != 1) //Check if shader failed to compile
            {
                Console.WriteLine("Vertex shader compilation failed!"); //Add log entry
                throw new Exception("Vertex shader could not compile!"); //Throw exception
            }

            GL.CompileShader(fid); //Compile fragment shader
            Console.WriteLine(GL.GetShaderInfoLog(fid)); //Log the shader info log
            int fstatus; GL.GetShader(fid, ShaderParameter.CompileStatus, out fstatus);
            if (fstatus != 1) //Check if shader failed to compile
            {
                Console.WriteLine("Fragment shader compilation failed!"); //Add log entry
                throw new Exception("Fragment shader could not compile!"); //Throw exception
            }

            GL.AttachShader(ProgramId, vid); //Attach shader object to program
            GL.AttachShader(ProgramId, fid);
            GL.LinkProgram(ProgramId); //Link the program
            GL.ValidateProgram(ProgramId);
            GL.DetachShader(ProgramId, vid); //Detach the shader object from program
            GL.DetachShader(ProgramId, fid);
            GL.DeleteShader(vid); //Delete shader objects
            GL.DeleteShader(fid);
        }

        //This constructor is mostly used for the bezier curve
        public ShaderProgram(string vertex, string fragment, string geometry)
        {
            ProgramId = GL.CreateProgram(); //Create shader program handle
            Bind(); //Bind the shader program to context

            int vid = GL.CreateShader(ShaderType.VertexShader); //Create shader object handle
            int fid = GL.CreateShader(ShaderType.FragmentShader);
            int gid = GL.CreateShader(ShaderType.GeometryShader);

            GL.ShaderSource(vid, vertex); //Input the shader source code
            GL.ShaderSource(fid, fragment);
            GL.ShaderSource(gid, geometry);

            GL.CompileShader(vid); //Compile the vertex shader
            Console.WriteLine(GL.GetShaderInfoLog(vid)); //Log the shader info log
            int vstatus; GL.GetShader(vid, ShaderParameter.CompileStatus, out vstatus);
            if (vstatus != 1) //Check if shader failed to compile
            {
                Console.WriteLine("Vertex shader compilation failed!"); //Add log entry
                throw new Exception("Vertex shader could not compile!"); //Throw exception
            }

            GL.CompileShader(fid); //Compile the fragment shader
            Console.WriteLine(GL.GetShaderInfoLog(fid)); //Log the shader info log
            int fstatus; GL.GetShader(fid, ShaderParameter.CompileStatus, out fstatus);
            if (fstatus != 1) //Check if shader failed to compile
            {
                Console.WriteLine("Fragment shader compilation failed!"); //Add log entry
                throw new Exception("Fragment shader could not compile!"); //Throw exception
            }

            GL.CompileShader(gid); //Compile the geometry shadeer
            Console.WriteLine(GL.GetShaderInfoLog(gid)); //Log the shader info log
            int gstatus; GL.GetShader(gid, ShaderParameter.CompileStatus, out gstatus);
            if (gstatus != 1) //Check if shader failed to compile
            {
                Console.WriteLine("Geometry shader compilation failed!"); //Add log entry
                throw new Exception("Geometry shader could not compile!"); //Throw exception
            }

            GL.AttachShader(ProgramId, vid); //Attach shader object to program
            GL.AttachShader(ProgramId, fid);
            GL.AttachShader(ProgramId, gid);

            GL.LinkProgram(ProgramId); //Link the shader program

            GL.DetachShader(ProgramId, vid); //Detach the shader object from the shader program
            GL.DetachShader(ProgramId, fid);
            GL.DeleteShader(vid); //Delete the shader program
            GL.DeleteShader(fid);
        }

        public void SetAttribLocation(string name, int id)
        {
            GL.BindAttribLocation(ProgramId, id, name);
        }

        //Binds program to context
        public void Bind()
        {
            GL.UseProgram(ProgramId);
        }

        //Safely disposes shader program
        public void Dispose()
        {
            if (ProgramId == -1) //Check if program was already disposed
            {
                Console.WriteLine("Duplicate dispose of shader program!"); //Log the duplicate dispose
                return; //Exit method
            }
            GL.DeleteProgram(ProgramId); //Deletes the program
            ProgramId = -1; //Marks program as disposed
        }

        //Checks if program was safely disposed
        ~ShaderProgram()
        {
            if (ProgramId != -1) //Checks if program was disposed
                Console.WriteLine("Shader program not disposed!"); //Log memory leak
        }

        public string ProgramLog { get { return GL.GetProgramInfoLog(ProgramId); } } //Gets the log of the shader program
        public int ProgramId { get; private set; } //Gets the program handle
    }
}