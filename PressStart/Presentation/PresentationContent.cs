using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart.Presentation
{
    static class PresentationContent
    {
        public static Texture2D Star { get; private set; }

        public static void Load(ContentManager content)
        {
            Star = content.Load<Texture2D>("Images/star");
        }
    }
}
