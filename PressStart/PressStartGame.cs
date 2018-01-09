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
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            Content.RootDirectory = "Content";
            Components.Add(new PresentationManager(this, 
                () => new Presentation.SpaceBackground(Presentation.PresentationContent.Star),
                () => Presentation.Deck.Slides,
                count => new Presentation.SpaceShipProgressTracker(count)));
        }
    }
}
