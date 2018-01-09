using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PressStart
{
    abstract class Renderer
    {
        public bool IsFragment { get; }
        public bool IsActive { get; private set; }
        public abstract int Height { get; }
        public abstract void Draw(SpriteBatch sb, int yOffset);
        protected Renderer(RendererOptions opts)
        {
            opts = opts ?? new RendererOptions();
            IsFragment = opts.IsFragment;
            IsActive = !opts.IsFragment;
        }
        public bool Activate() => IsActive = true;
    }
}
