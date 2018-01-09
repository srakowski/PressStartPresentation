using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    abstract class Background
    {
        public virtual void Update(GameTime gameTime, int direction) { } 
        public abstract void Draw(SpriteBatch sb);
    }
}
