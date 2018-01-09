using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace PressStart.Presentation
{
    static class PresentationContent
    {
        public static Dictionary<string, Texture2D> Images { get; } = new Dictionary<string, Texture2D>();

        public static Dictionary<string, Song> Songs { get; } = new Dictionary<string, Song>();

        public static Texture2D Star => Images["Images/star"];

        public static void Load(ContentManager content)
        {
            var img = new Action<string>(path => Images[path] = content.Load<Texture2D>(path));
            img("Images/star");
            img("Images/jpl");
            img("Images/nasa-logo");
            img("Images/nate-jones");
            img("Images/play");
            img("Images/github");
            img("Images/onlyyou");
            img("Images/sbs");
            img("Images/desert");
            img("Images/sandbox");
            img("Images/ld");
            img("Images/igj");
            img("Images/pico8");

            var song = new Action<string>(path => Songs[path] = content.Load<Song>(path));
            song("Audio/ItsOnlyYou");
        }
    }
}
