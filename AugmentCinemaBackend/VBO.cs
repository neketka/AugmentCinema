using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace AugmentCinemaBackend
{
    /*
     * This class is a wrapper for the OpenGL VBO
     */
    public class VBO<T> : IDisposable where T : struct
    {
        public VBO(T[] data, bool indices) //The constructor
        {
            target = indices ? BufferTarget.ElementArrayBuffer : BufferTarget.ArrayBuffer; //Sets the target for binding
            Type t = typeof(T); //Gets the type object of the elements
            AttribSize = t == typeof(Vector2) ? 2 : t == typeof(Vector3) ? 3 : t == typeof(Vector4) ? 4 : 1; //Gets the element attribute length
            Length = data.Length; //Gets the amount of elements
            VBOId = GL.GenBuffer(); //Creates the VBO handle
            Bind(); //Binds the VBO to context
            GL.BufferData(target, (IntPtr)(data.Length * Marshal.SizeOf<T>()), data, BufferUsageHint.StaticDraw); //Sends elements to GPU
        }

        public void Bind() //Binds VBO to context
        {
            GL.BindBuffer(target, VBOId);
        }

        public void Dispose() //Safely disposes of the VBO
        {
            if (VBOId == -1) //Check if VBO was already disposed
            {
                Console.WriteLine("Duplicate dispose of VBO!"); //Log duplicate dispose
                return; //Exit method
            }
            GL.DeleteBuffer(VBOId); //Delete the VBO
            VBOId = -1; //Mark VBO as disposed
        }

        ~VBO() //Checks if VBO was safely disposed
        {
            if (VBOId != -1) //Check if VBO was disposed
                Console.WriteLine("VBO was not disposed!"); //Log memory leak
        }

        public int AttribSize { get; private set; } //Gets the element length
        public int VBOId { get; private set; } //Gets the vbo handle
        public int Length { get; private set; } //Gets the amount of elements
        private BufferTarget target; //Gets the binding target
    }
}