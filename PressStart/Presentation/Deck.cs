using System.Collections.Generic;

namespace PressStart.Presentation
{
    static class Deck
    {
        public static IEnumerable<Slide> Slides => new []
        {
            PressStartSlide,
            TitleSlide,
            NotPassionateAboutGames,
            YouAreAwesome,
            WhyItMakesYouMoreAwesome,
            JplPicture,
            NateJones,
            PlaySlide,
            ActivityGraph,
            WhyItMakesYouMoreAwesome2,
            ItsOnlyYou,
            ArtSlide,
            SatSlide,
            SuperBigSister,
            MonetizeSlide,
            Blank,
            InitiatingTheHobby,
            Desert,
            Sandbox,
            GameDevSandboxes,
            GameJams,
            IndieGameJams,
            FantasyConsoles,
        };

        static Slide PressStartSlide => new Slide()
            .Title("Press Start");

        static Slide TitleSlide => new Slide()
            .Title("Game Development for the Uninitiated")
            .SubTitle("Shawn Rakowski")
            .SubTitle("@Shwany", new RendererOptions { IsFragment = true})
            .SubTitle("@realDonaldTrump", new RendererOptions { IsFragment = true });

        static Slide NotPassionateAboutGames => new Slide()
            .Title("I am NOT passionate about games.");

        static Slide YouAreAwesome => new Slide()
            .Title("You are AWESOME!")
            .SubTitle("And game dev can make you even more awesome!", Fragment);

        static Slide WhyItMakesYouMoreAwesome => new Slide()
            .Title("Why?")
            .SubTitle("1. Recreational programming is a concrete way to become a better developer.", Fragment)
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational programming.", Fragment);

        static Slide JplPicture => new Slide()
            .Image("Images/jpl", Scale(0.6f));

        static Slide NateJones => new Slide()
            .Image("Images/nate-jones", Scale(0.8f));

        static Slide PlaySlide = new Slide()
            .Image("Images/play");

        static Slide ActivityGraph = new Slide()
            .Image("Images/github");

        static Slide WhyItMakesYouMoreAwesome2 => new Slide()
            .Title("Why?")
            .SubTitle("1. Recreational programming is a concrete way to become a better developer.", Alpha(0.5f))
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational programming.");

        static Slide ItsOnlyYou => new Slide()
            .Image("Images/onlyyou")
            .Song("Audio/ItsOnlyYou");

        static Slide ArtSlide => new Slide()
            .Title("[TODO ART]");

        static Slide SatSlide => new Slide()
            .Title("[TODO SAT]");

        static Slide SuperBigSister => new Slide()
            .Image("Images/sbs");

        static Slide MonetizeSlide => new Slide()
            .Title("[TOOD MONEY]");

        static Slide InitiatingTheHobby => new Slide()
            .Title("Initiating");

        static Slide Desert => new Slide()
            .Image("Images/desert");

        static Slide Sandbox => new Slide()
            .Image("Images/sandbox", Scale(0.8f));

        static Slide GameDevSandboxes => new Slide()
            .Title("Game Dev Sandboxes")
            .SubTitle("1. Game Jams", Fragment)
            .SubTitle("2. Fantasy Consoles", Fragment);

        static Slide GameJams => new Slide()
            .Title("Game Jams")
            .Image("Images/ld", Fragment);

        static Slide IndieGameJams => new Slide()
            .Image("Images/igj", Scale(0.6f));

        static Slide FantasyConsoles => new Slide()
            .Title("Fantasy Consoles")
            .Image("Images/pico8", Fragment);

        static Slide Blank => new Slide();

        static RendererOptions Alpha(float alpha) => new RendererOptions { Alpha = alpha };

        static RendererOptions Fragment => new RendererOptions { IsFragment = true };

        static RendererOptions Scale(float s) => new RendererOptions { Scale = s };
    }
}
