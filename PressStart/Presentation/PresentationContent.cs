using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace PressStart.Presentation
{
    static class PresentationContent
    {
        public static Dictionary<string, Texture2D> Images { get; } = new Dictionary<string, Texture2D>();

        public static Dictionary<string, Song> Songs { get; } = new Dictionary<string, Song>();

        public static Dictionary<string, SoundEffect> SoundEffects { get; } = new Dictionary<string, SoundEffect>();

        public static Texture2D Star => Images["Images/star"];

        public static Texture2D Ship => Images["Images/pirate"];

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
            img("Images/sat");
            img("Images/takemymoney");
            img("Images/twine");
            img("Images/udemy");
            img("Images/seasquirt");
            img("Images/braid");
            img("Images/kenney");
            img("Images/phaser");
            img("Images/pirate");

            var song = new Action<string>(path => Songs[path] = content.Load<Song>(path));
            song("Audio/ItsOnlyYou");
            song("Audio/abm");
            song("Audio/Hot Pursuit");
            song("Audio/Dreamy Flashback");

            var sfx = new Action<string>(path => SoundEffects[path] = content.Load<SoundEffect>(path));
            sfx("Audio/explode");
            sfx("Audio/jump");
            sfx("Audio/coin");
        }
    }
}
