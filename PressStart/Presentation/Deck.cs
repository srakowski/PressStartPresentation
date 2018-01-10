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
            .Title("Press Start", Center);

        static Slide TitleSlide => new Slide()
            .Title("Game Development for the Uninitiated", Center)
            .SubTitle("Shawn Rakowski - CodeMash 2.0.18", Center)
            .SubTitle("@Shwany", Center)
            .SubTitle("@realDonaldTrump", Fragment.Center());

        static Slide NotPassionateAboutGames => new Slide()
            .Title("I am NOT passionate about games.", Center);

        static Slide YouAreAwesome => new Slide()
            .Title("You are AWESOME!", Center)
            .SubTitle("Game dev can make you even more awesome!", Fragment.Center());

        static Slide WhyItMakesYouMoreAwesome => new Slide()
            .Title("Why?")
            .SubTitle("1. Recreational software development is a concrete way to become a better developer.", Fragment)
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational software development.", Fragment);

        static Slide JplPicture => new Slide()
            .Image("Images/jpl", Scale(0.6f));

        static Slide NateJones => new Slide()
            .Image("Images/nate-jones", Scale(0.8f));

        static Slide PlaySlide = new Slide()
            .Image("Images/play", Scale(1.60f));

        static Slide ActivityGraph = new Slide()
            .Image("Images/github", Scale(1.60f));

        static Slide WhyItMakesYouMoreAwesome2 => new Slide()
            .Title("Why?")
            .SubTitle("1. Recreational programming is a concrete way to become a better developer.", Alpha(0.5f))
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational programming.");

        static Slide ItsOnlyYou => new Slide()
            .Image("Images/onlyyou", Scale(1.50f))
            .Song("Audio/ItsOnlyYou");

        static Slide SatSlide => new Slide()
            .Image("Images/sat", Scale(1.50f));

        static Slide SuperBigSister => new Slide()
            .Image("Images/sbs", Scale(1.50f));

        static Slide MonetizeSlide => new Slide()
            .Image("Images/takemymoney");

        static Slide InitiatingTheHobby => new Slide()
            .Title("Initiating", Center);

        static Slide Desert => new Slide()
            .Image("Images/desert", Scale(1.20f));

        static Slide Sandbox => new Slide()
            .Image("Images/sandbox", Scale(0.8f));

        static Slide GameDevSandboxes => new Slide()
            .Title("Game Dev Sandboxes")
            .SubTitle("- Game Jams")
            .SubTitle("- Fantasy Consoles");

        static Slide GameJams => new Slide()
            .Title("Game Jams", Center)
            .Image("Images/ld", Fragment)
            .SubText("ldjam.com", Fragment.AutoNextFragment().Center());

        static Slide LudumDare => new Slide()
            .Title("Ludum Dare \"Compo\" Mode")
            .SubTitle("- 48 hours")
            .SubTitle("- Solo")
            .SubTitle("- All assets made during the event")
            .SubTitle("- Source code must be submitted");

        static Slide LudumDareJam => new Slide()
            .Title("Ludum Dare \"Jam\" Mode")
            .SubTitle("- 72 hours")
            .SubTitle("- Teams")
            .SubTitle("- Premade assets okay");

        static Slide WhyGameJams => new Slide()
            .Title("Game Jams Rock!", Center);

        static Slide IndieGameJams => new Slide()
            .Image("Images/igj", Scale(0.8f).Center())
            .SubText("www.indiegamejams.com", Center);

        static Slide FantasyConsoles => new Slide()
            .Title("Fantasy Consoles", Center)
            .Image("Images/pico8", Fragment.Center())
            .SubText("www.lexaloffle.com/pico-8.php", Fragment.Center().AutoNextFragment());

        static Slide OtherFantasyConsoles => new Slide()
            .Title("Other Fantasy Consoles")
            .SubTitle("- TIC-80 (tic.computer) (Free)")
            .SubTitle("- PixelVision8 (pixelvision8.com)");

        static Slide Resources => new Slide()
            .Title("github.com/srakowski/game-dev-resources", Center);

        static Slide DoYouNeed => new Slide()
            .Title("Engines and Frameworks")
            .SubTitle("1. Do I need one?", Fragment)
            .SubTitle("2. What do I want to build?", Fragment);

        static Slide Twine => new Slide()
            .Image("Images/twine", Center)
            .SubText("twinery.org", Center);

        static Slide DoYouNeed2 => new Slide()
            .Title("Engines and Frameworks")
            .SubTitle("1. Do I need one?")
            .SubTitle("2. What do I want to build?")
            .SubTitle("3. What do I want out of game dev?", Fragment);

        static Slide Phaser => new Slide()
            .Image("Images/phaser", Center)
            .SubText("phaser.io", Center);

        static Slide GraphicsAndAudio => new Slide()
            .Title("Graphics and Audio", Center)
            .SubTitle("Do I need them?", Fragment.Center());

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
            .Title("SFXR", Center)
            .SubText("www.drpetter.se/project_sfxr.html", Center)
            .SubTitle("[Coin]", Play("Audio/coin").Center())
            .SubTitle("[Explosion]", Play("Audio/explode").Center())
            .SubTitle("[Jump]", Play("Audio/jump").Center());

        static Slide AM => new Slide()
            .Title("Generated By Abundant Music", Center)
            .SubText("abundant-music.com", Center)
            .Song("Audio/abm");

        static Slide StrategiesForAC3 => new Slide()
            .Title("Strategies for the Artistically Challenged")
            .SubTitle("1. Embrace \"Programmer Art\"")
            .SubTitle("2. Generate assets")
            .SubTitle("3. Use other people's assets", Fragment);

        static Slide Kenney => new Slide()
            .SubTitle("Kenney Asset Packs", Center)
            .Image("Images/kenney", Center)
            .SubText("kenney.nl", Center);

        static Slide Incompetech => new Slide()
            .Title("Incompetech.com", Center)
            .SubTitle("Royalty Free Music by Kevin Macleod", Center)
            .SubText("http://incompetech.com/music/", Center);

        static Slide IncompetechExample => new Slide()
            .Title("Action", Center)
            .SubText("Hot Pursuit Kevin MacLeod (incompetech.com)", Center)
            .SubText("Licensed under Creative Commons: By Attribution 3.0 License", Center)
            .SubText("http://creativecommons.org/licenses/by/3.0/", Center)
            .Song("Audio/Hot Pursuit");

        static Slide IncompetechExample2 => new Slide()
            .Title("Wonder", Center)
            .SubText(@"Dreamy Flashback Kevin MacLeod (incompetech.com)", Center)
            .SubText("Licensed under Creative Commons: By Attribution 3.0 License", Center)
            .SubText("http://creativecommons.org/licenses/by/3.0/", Center)
            .Song("Audio/Dreamy Flashback");

        static Slide Udemy => new Slide()
            .Image("Images/udemy", Scale(1.20f));

        static Slide LearningPre => new Slide()
            .Title("Resources for Learning", Center);

        static Slide Learning => new Slide()
            .Title("Resources for Learning")
            .SubTitle("- GameFromScratch (gamefromscratch.com)", Fragment)
            .SubTitle("- Handmade Hero (handmadehero.org)", Fragment)
            .SubTitle("- @McFunkyPants (twitter.com/McFunkypants)", Fragment)
            .SubTitle("- Lostcast (lostdecadegames.com/lostcast)", Fragment);

        static Slide Distributing => new Slide()
            .Title("Distributing Your Game $$$")
            .SubTitle("- Itch (itch.io)", Fragment)
            .SubTitle("- Humble Gamepages (humblebundle.com/developer)", Fragment)
            .SubTitle("- Xbox Live Creators Program (www.xbox.com/en-US/developers/creators-program)", Fragment)
            .SubTitle("- Steam Direct (partner.steamgames.com/steamdirect)", Fragment);

        static Slide SeaSquirt => new Slide()
            .Image("Images/seasquirt", Scale(0.8f));

        static Slide ThankYou => new Slide()
            .Title("Thank you!", Center)
            .SubTitle("@Shwany", Center)
            .SubTitle("github.com/srakowski/game-dev-resources", Center);

        static Slide Blank => new Slide();

        static RendererOptions Alpha(float alpha) => new RendererOptions { Alpha = alpha };

        static RendererOptions Center => new RendererOptions { Center = true };

        static RendererOptions Fragment => new RendererOptions { IsFragment = true };

        static RendererOptions Scale(float s) => new RendererOptions { Scale = s };

        static RendererOptions Play(string sfx) => new RendererOptions { IsFragment = true, SoundEffect = sfx };
    }
}
