using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    public class PressStartGame : Game
    {
        GraphicsDeviceManager graphics;

        public PressStartGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = Stage.WIDTH;
            graphics.PreferredBackBufferHeight = Stage.HEIGHT;
            Content.RootDirectory = "Content";
            Components.Add(new PresentationManager(this, 
                () => new Presentation.SpaceBackground(Presentation.PresentationContent.Star),
                () => Presentation.Deck.Slides,
                count => new Presentation.SpaceShipProgressTracker(count)));
            graphics.IsFullScreen = true;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (Input.WasKeyPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                if (graphics.IsFullScreen)
                {
                    graphics.PreferredBackBufferWidth = 1280;
                    graphics.PreferredBackBufferHeight = 720;
                    graphics.IsFullScreen = false;
                }
                else
                {
                    graphics.PreferredBackBufferWidth = Stage.WIDTH;
                    graphics.PreferredBackBufferHeight = Stage.HEIGHT;
                    graphics.IsFullScreen = true;
                }
                graphics.ApplyChanges();
            }
        }
    }
}
