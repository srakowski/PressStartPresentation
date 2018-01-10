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
            SatSlide,
            SuperBigSister,
            MonetizeSlide,
            Blank,
            InitiatingTheHobby,
            Desert,
            Sandbox,
            GameDevSandboxes,
            GameJams,
            LudumDare,
            LudumDareJam,
            WhyGameJams,
            IndieGameJams,
            FantasyConsoles,
            OtherFantasyConsoles,
            Resources,
            DoYouNeed,
            Twine,
            DoYouNeed2,
            Phaser,
            GraphicsAndAudio,
            StrategiesForAC,
            Braid,
            StrategiesForAC2,
            Sfxr,
            AM,
            StrategiesForAC3,
            Kenney,
            Incompetech,
            IncompetechExample,
            Blank,
            IncompetechExample2,
            Blank,
            LearningPre,
            Udemy,
            Learning,
            Distributing,
            SeaSquirt,
            ThankYou,
        };

        static Slide PressStartSlide => new Slide()
            .Title("Press Start");

        static Slide TitleSlide => new Slide()
            .Title("Game Development for the Uninitiated")
            .SubTitle("Shawn Rakowski")
            .SubTitle("CodeMash 2.0.18")
            .SubTitle("@Shwany")
            .SubTitle("@realDonaldTrump", Fragment);

        static Slide NotPassionateAboutGames => new Slide()
            .Title("I am NOT passionate about games.");

        static Slide YouAreAwesome => new Slide()
            .Title("You are AWESOME!")
            .SubTitle("And game dev can make you even more awesome!", Fragment);

        static Slide WhyItMakesYouMoreAwesome => new Slide()
            .Title("Why?")
            .SubTitle("1. Recreational software development is a concrete way to become a better developer.", Fragment)
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational software development.", Fragment);

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

        static Slide SatSlide => new Slide()
            .Image("Images/sat");

        static Slide SuperBigSister => new Slide()
            .Image("Images/sbs");

        static Slide MonetizeSlide => new Slide()
            .Image("Images/takemymoney");

        static Slide InitiatingTheHobby => new Slide()
            .Title("Initiating");

        static Slide Desert => new Slide()
            .Image("Images/desert");

        static Slide Sandbox => new Slide()
            .Image("Images/sandbox", Scale(0.8f));

        static Slide GameDevSandboxes => new Slide()
            .Title("Game Dev Sandboxes")
            .SubTitle("- Game Jams")
            .SubTitle("- Fantasy Consoles");

        static Slide GameJams => new Slide()
            .Title("Game Jams")
            .Image("Images/ld", Fragment);

        static Slide LudumDare => new Slide()
            .Title("Ludum Dare Compo")
            .SubTitle("- 48 hours")
            .SubTitle("- Solo")
            .SubTitle("- All assets made during the event")
            .SubTitle("- Source code must be submitted");

        static Slide LudumDareJam => new Slide()
            .Title("Ludum Dare Jam")
            .SubTitle("- 72 hours")
            .SubTitle("- Teams")
            .SubTitle("- Premade assets okay");

        static Slide WhyGameJams => new Slide()
            .Title("Why Game Jams?")
            .SubTitle("1. Scheduled and timeboxed", Fragment)
            .SubTitle("2. Collaborative", Fragment);

        static Slide IndieGameJams => new Slide()
            .Title("Where to find game jams?")
            .SubTitle("http://www.indiegamejams.com/")
            .Image("Images/igj", Scale(0.8f));

        static Slide FantasyConsoles => new Slide()
            .Title("Fantasy Consoles")
            .Image("Images/pico8", Fragment);

        static Slide OtherFantasyConsoles => new Slide()
            .Title("Other Fantasy Consoles")
            .SubTitle("- TIC-80 https://tic.computer/ (Free)")
            .SubTitle("- PixelVision8 http://pixelvision8.com/");

        static Slide Resources => new Slide()
            .Title("Resources:")
            .SubTitle("https://github.com/srakowski/game-dev-resources");

        static Slide DoYouNeed => new Slide()
            .Title("Engines and Frameworks")
            .SubTitle("1. Do I need one?", Fragment)
            .SubTitle("2. What do I want to build?", Fragment);

        static Slide Twine => new Slide()
            .Image("Images/twine");

        static Slide DoYouNeed2 => new Slide()
            .Title("Engines and Frameworks")
            .SubTitle("1. Do I need one?")
            .SubTitle("2. What do I want to build?")
            .SubTitle("3. What do I want out of game dev?", Fragment);

        static Slide Phaser => new Slide()
            .Image("Images/phaser");

        static Slide GraphicsAndAudio => new Slide()
            .Title("Graphics and Audio")
            .SubTitle("Do I need them?", Fragment);

        static Slide StrategiesForAC => new Slide()
            .Title("Strategies for the Artistically Challenged")
            .SubTitle("1. Embrace \"Programmer Art\"", Fragment);

        static Slide Braid => new Slide()
            .Image("Images/braid", Scale(0.8f));

        static Slide StrategiesForAC2 => new Slide()
            .Title("Strategies for the Artistically Challenged")
            .SubTitle("1. Embrace \"Programmer Art\"")
            .SubTitle("2. Generate assets", Fragment);

        static Slide Sfxr => new Slide()
            .Title("SFXR/BFXR")
            .SubTitle("- Coin", Play("Audio/coin"))
            .SubTitle("- Explosion", Play("Audio/explode"))
            .SubTitle("- Jump", Play("Audio/jump"));

        static Slide AM => new Slide()
            .Title("Abundant Music")
            .Song("Audio/abm");

        static Slide StrategiesForAC3 => new Slide()
            .Title("Strategies for the Artistically Challenged")
            .SubTitle("1. Embrace \"Programmer Art\"")
            .SubTitle("2. Generate assets")
            .SubTitle("3. Use other people's assets", Fragment);

        static Slide Kenney => new Slide()
            .Title("Kenney Assets")
            .Image("Images/kenney");

        static Slide Incompetech => new Slide()
            .Title("Incompetech")
            .SubTitle("http://incompetech.com/music/");

        static Slide IncompetechExample => new Slide()
            .Title("Action")
            .SubTitle(@"Hot Pursuit Kevin MacLeod (incompetech.com)
Licensed under Creative Commons: By Attribution 3.0 License
http://creativecommons.org/licenses/by/3.0/")
            .Song("Audio/Hot Pursuit");

        static Slide IncompetechExample2 => new Slide()
            .Title("Wonder")
            .SubTitle(@"Dreamy Flashback Kevin MacLeod (incompetech.com)
Licensed under Creative Commons: By Attribution 3.0 License
http://creativecommons.org/licenses/by/3.0/")
            .Song("Audio/Dreamy Flashback");

        static Slide Udemy => new Slide()
            .Image("Images/udemy");

        static Slide LearningPre => new Slide()
            .Title("Resources for Learning");

        static Slide Learning => new Slide()
            .Title("Resources for Learning")
            .SubTitle("- GameFromScratch", Fragment)
            .SubTitle("- Handmade Hero", Fragment)
            .SubTitle("- @McFunkyPants", Fragment)
            .SubTitle("- Lostcast", Fragment);

        static Slide Distributing => new Slide()
            .Title("Distributing Your Game")
            .SubTitle("- Itch.io", Fragment)
            .SubTitle("- Humble Gamepages", Fragment)
            .SubTitle("- Xbox Live Creators Program", Fragment)
            .SubTitle("- Steam Direct", Fragment);

        static Slide SeaSquirt => new Slide()
            .Image("Images/seasquirt", Scale(0.8f));

        static Slide ThankYou => new Slide()
            .Title("Thank you!")
            .SubTitle("@Shwany")
            .SubTitle("Resources: https://github.com/srakowski/game-dev-resources");

        static Slide Blank => new Slide();

        static RendererOptions Alpha(float alpha) => new RendererOptions { Alpha = alpha };

        static RendererOptions Fragment => new RendererOptions { IsFragment = true };

        static RendererOptions Scale(float s) => new RendererOptions { Scale = s };

        static RendererOptions Play(string sfx) => new RendererOptions { IsFragment = true, SoundEffect = sfx };
    }
}
