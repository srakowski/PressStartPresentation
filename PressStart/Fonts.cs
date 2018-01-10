using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    static internal class Fonts
    {
        public static SpriteFont H1 { get; private set; }

        public static SpriteFont H2 { get; private set; }

        public static SpriteFont SubText { get; private set; }

        public static void Load(ContentManager content)
        {
            H1 = content.Load<SpriteFont>("Fonts/H1");
            H2 = content.Load<SpriteFont>("Fonts/H2");
            SubText = content.Load<SpriteFont>("Fonts/SubText");
        }
    }
}
