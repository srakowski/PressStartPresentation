using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart.Presentation
{
    class SpaceShipProgressTracker : ProgressTracker
    {
        private Vector2 _pos;

        private Vector2 _targetPos;

        private float _time = 0;

        public SpaceShipProgressTracker(int nodeCount) : base(nodeCount)
        {
            _pos = new Vector2(Stage.WIDTH * (1f / (float)nodeCount), Stage.HEIGHT - PresentationContent.Ship.Width - 10);
            _targetPos = _pos;
        }

        public override void Update(GameTime gameTime)
        {
            if (_pos == _targetPos) return;

            _time += gameTime?.ElapsedGameTime.Milliseconds ?? 0;
            var t = _time / 500f;
            _pos = Vector2.SmoothStep(_pos, _targetPos, t);

            if (Vector2.Distance(_pos, _targetPos) < 1) _pos = _targetPos;
        }

        protected override void Draw(SpriteBatch sb, int idx, int count)
        {
            var targetPos = new Vector2(Stage.WIDTH * ((float)(idx + 1) / (float)count), Stage.HEIGHT - PresentationContent.Ship.Width - 10);
            if (targetPos != _targetPos) _time = 0;
            _targetPos = targetPos;
            sb.Begin();
            sb.Draw(texture: PresentationContent.Ship,
                position: _pos,
                color: Color.White,
                rotation: MathHelper.ToRadians(90f));
            sb.End();
        }
    }
}
