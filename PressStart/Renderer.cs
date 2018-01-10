using Microsoft.Xna.Framework;
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
        public bool AutoNext => IsFragment && Options.AutoNextFragment;
        public abstract int Height { get; }
        protected RendererOptions Options { get; }
        public virtual void Update(GameTime gameTime) { }
        public abstract void Draw(SpriteBatch sb, int yOffset, int totalHeight);
        protected Renderer(RendererOptions opts)
        {
            Options = opts ?? new RendererOptions();
            IsFragment = Options.IsFragment;
            IsActive = !Options.IsFragment;
        }
        public bool Activate()
        {
            IsActive = true;
            if (Options.SoundEffect != null)
                Presentation.PresentationContent.SoundEffects[Options.SoundEffect].Play();
            return IsActive;
        }
    }
}
