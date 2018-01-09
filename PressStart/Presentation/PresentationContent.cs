using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart.Presentation
{
    static class PresentationContent
    {
        public static Dictionary<string, Texture2D> Images { get; set; } = new Dictionary<string, Texture2D>();

        public static Texture2D Star => Images["Images/star"];

        public static void Load(ContentManager content)
        {
            var img = new Action<string>(path => LoadImage(content, path));
            img("Images/star");
            img("Images/jpl");
            img("Images/nasa-logo");
            img("Images/nate-jones");
            img("Images/play");
        }

        private static void LoadImage(ContentManager content, string path) =>
            Images[path] = content.Load<Texture2D>(path);
    }
}
