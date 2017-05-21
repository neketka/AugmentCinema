using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;

namespace AugmentCinemaBackend
{
    /*
     * Texture2D wrapper class
     */
    public class Texture2D : IDisposable
    {
        public Texture2D(System.Drawing.Bitmap bmp) //Main texture constructor
        {
            bmp.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY);
            TextureId = GL.GenTexture(); //Get texture handle
            Bind(0); //Bind texture
            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb); //Create unmanaged bmp handle
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba8, bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0); //Send image data to texture
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
        }

        public Texture2D(int width, int height)
        {
            TextureId = GL.GenTexture(); //Get texture handle
            Bind(0); //Bind texture
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba8, width, height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero); //Send image data to texture
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
        }

        public void Bind(int unit) //Binds texture to unit
        {
            GL.ActiveTexture(TextureUnit.Texture0 + unit); //Bind unit
            GL.BindTexture(TextureTarget.Texture2D, TextureId); //Bind texture
        }

        public void Dispose()
        {
            if (TextureId == -1)
                GL.DeleteTexture(TextureId); //Disposes texture
        }

        public int TextureId { get; private set; } //Stores handle of texture
    }

    public class TextureDepth : IDisposable
    {
        public TextureDepth(int width, int height)
        {
            TextureId = GL.GenTexture(); //Get texture handle
            Bind(0); //Bind texture
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.DepthComponent24, width, height, 0, OpenTK.Graphics.OpenGL.PixelFormat.DepthComponent, PixelType.Float, IntPtr.Zero); //Send image data to texture
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
        }

        public void Bind(int unit) //Binds texture to unit
        {
            GL.ActiveTexture(TextureUnit.Texture0 + unit); //Bind unit
            GL.BindTexture(TextureTarget.Texture2D, TextureId); //Bind texture
        }

        public void Dispose()
        {
            if (TextureId == -1)
                GL.DeleteTexture(TextureId); //Disposes texture
        }

        public int TextureId { get; private set; } //Stores handle of texture
    }

    public class TextureDepthStencil : IDisposable
    {
        public TextureDepthStencil(int width, int height)
        {
            TextureId = GL.GenTexture(); //Get texture handle
            Bind(0); //Bind texture
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.DepthStencil, width, height, 0, OpenTK.Graphics.OpenGL.PixelFormat.DepthStencil, PixelType.Float, IntPtr.Zero); //Send image data to texture
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
        }

        public void Bind(int unit) //Binds texture to unit
        {
            GL.ActiveTexture(TextureUnit.Texture0 + unit); //Bind unit
            GL.BindTexture(TextureTarget.Texture2D, TextureId); //Bind texture
        }

        public void Dispose()
        {
            if (TextureId == -1)
                GL.DeleteTexture(TextureId); //Disposes texture
        }

        public int TextureId { get; private set; } //Stores handle of texture
    }
}