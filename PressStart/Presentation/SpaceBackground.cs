using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace PressStart.Presentation
{
    class SpaceBackground : Background
    {
        private Texture2D _starTexture;

        private IEnumerable<Star> _stars;

        class Star
        {
            public Vector2 Position { get; set; }
            public Color Color { get; set; }
        }

        public SpaceBackground(Texture2D starTexture)
        {
            _starTexture = starTexture;
            var random = new Random();
            var stars = new List<Star>();
            for (int i = 0; i < 100; i++)
                stars.Add(new Star
                {
                    Position = new Vector2(random.Next(Stage.WIDTH), random.Next(Stage.HEIGHT)),
                    Color = new Color(random.Next(255), random.Next(255), random.Next(255), random.Next(50, 250)),
                });
            _stars = stars;
        }

        public override void Update(GameTime gameTime, int direction)
        {
            foreach (var star in _stars)
            {
                star.Position += new Vector2(direction * star.Color.A * (((float)gameTime.ElapsedGameTime.TotalSeconds/2f)), 0f);
                if (star.Position.X < 0) star.Position += new Vector2(Stage.WIDTH, 0f);
                if (star.Position.X > Stage.WIDTH) star.Position -= new Vector2(Stage.WIDTH, 0f);
            }
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Begin(blendState: BlendState.NonPremultiplied);
            foreach (var star in _stars)
                sb.Draw(_starTexture, star.Position, star.Color);
            sb.End();
        }
    }
}
