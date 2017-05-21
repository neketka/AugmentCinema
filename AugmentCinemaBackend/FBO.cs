using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace AugmentCinemaBackend
{
    public class FBO : IDisposable
    {
        public FBO(bool read, bool draw)
        {
            if (!(read || draw)) throw new Exception("An FBO cannot be neither read nor draw.");
            FBOId = GL.GenFramebuffer();
            renderbuffers = new List<int>();
            readable = read;
            drawable = draw;
            Target = read && draw ? FramebufferTarget.Framebuffer : read ? FramebufferTarget.ReadFramebuffer : draw ? FramebufferTarget.DrawFramebuffer : FramebufferTarget.Framebuffer;
        }

        public void Clear()
        {
            if (!drawable) throw new Exception("FBO is not drawable!");
            Bind();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
        }

        private FBO(int id, bool read, bool draw)
        {
            FBOId = 0;
            readable = read;
            drawable = draw;
            Target = read && draw ? FramebufferTarget.Framebuffer : read ? FramebufferTarget.ReadFramebuffer : draw ? FramebufferTarget.DrawFramebuffer : FramebufferTarget.Framebuffer;
        }

        public void AddColorAttachment(Texture2D tex, int attachment)
        {
            Bind();
            GL.FramebufferTexture2D(Target, FramebufferAttachment.ColorAttachment0 + attachment, TextureTarget.Texture2D, tex.TextureId, 0);
        }

        public void AddColorAttachment(int width, int height, int attachment)
        {
            Bind();
            int id = GL.GenRenderbuffer();
            GL.RenderbufferStorage(RenderbufferTarget.Renderbuffer, RenderbufferStorage.Rgba8, width, height);
            GL.FramebufferRenderbuffer(Target, FramebufferAttachment.ColorAttachment0 + attachment, RenderbufferTarget.Renderbuffer, id);
            renderbuffers.Add(id);
        }

        public void AddDepthAttachment(TextureDepth tex)
        {
            Bind();
            GL.FramebufferTexture2D(Target, FramebufferAttachment.DepthAttachment, TextureTarget.Texture2D, tex.TextureId, 0);
        }

        public void AddDepthAttachment(int width, int height)
        {
            Bind();
            int id = GL.GenRenderbuffer();
            GL.RenderbufferStorage(RenderbufferTarget.Renderbuffer, RenderbufferStorage.DepthComponent24, width, height);
            GL.FramebufferRenderbuffer(Target, FramebufferAttachment.DepthAttachment, RenderbufferTarget.Renderbuffer, id);
            renderbuffers.Add(id);
        }

        public void AddDepthStencilAttachment(TextureDepthStencil tex)
        {
            Bind();
            GL.FramebufferTexture2D(Target, FramebufferAttachment.DepthStencilAttachment, TextureTarget.Texture2D, tex.TextureId, 0);
        }

        public void AddDepthStencilAttachment(int width, int height)
        {
            Bind();
            int id = GL.GenRenderbuffer();
            GL.RenderbufferStorage(RenderbufferTarget.Renderbuffer, RenderbufferStorage.Depth24Stencil8, width, height);
            GL.FramebufferRenderbuffer(Target, FramebufferAttachment.DepthStencilAttachment, RenderbufferTarget.Renderbuffer, id);
            renderbuffers.Add(id);
        }

        public void ReadColorBuffer(int attachment)
        {
            Bind();
            if (!readable) throw new Exception("FBO is not readable!");
            GL.ReadBuffer(ReadBufferMode.ColorAttachment0 + attachment);
        }

        public void DrawColorBuffer(int attachment)
        {
            Bind();
            GL.DrawBuffer(DrawBufferMode.ColorAttachment0 + attachment);
        }

        public void DrawColorBuffers(params int[] colorattach)
        {
            List<DrawBuffersEnum> buffers = new List<DrawBuffersEnum>();
            Bind();
            if (!drawable) throw new Exception("FBO is not drawable!");
            foreach (int cattach in colorattach) { buffers.Add(DrawBuffersEnum.ColorAttachment0 + cattach); }
            GL.DrawBuffers(colorattach.Length, buffers.ToArray());
        }

        public void Bind()
        {
            GL.BindFramebuffer(Target, FBOId);
        }

        public void Dispose()
        {
            GL.DeleteFramebuffer(FBOId);
            renderbuffers.ForEach((i) => { GL.DeleteRenderbuffer(i); });
        }

        public readonly static FBO DeviceFramebuffer = new FBO(0, true, true);

        public int FBOId { get; private set; }
        public FramebufferTarget Target { get; private set; }
        private bool drawable;
        private bool readable;
        private List<int> renderbuffers;
    }
}