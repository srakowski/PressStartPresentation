using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    abstract class ProgressTracker
    {
        private int _nodeCount;

        private int _nodeIdx;

        public ProgressTracker(int nodeCount) => _nodeCount = nodeCount;

        public void UpdateProgress(int idx)
        {
            _nodeIdx = MathHelper.Clamp(idx, 0, _nodeCount);
        }

        public virtual void Update(GameTime gameTime) { }

        public void Draw(SpriteBatch sb) => Draw(sb, _nodeIdx, _nodeCount);

        protected abstract void Draw(SpriteBatch sb, int idx, int count);
    }
}
