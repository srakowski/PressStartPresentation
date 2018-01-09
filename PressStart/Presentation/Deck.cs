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
            .SubTitle("1. Recreational programming is a concrete way to become a better developer", Fragment)
            .SubTitle("2. Games are one of the best domains to initiate, maintain, and enjoy a habit of recreational programming", Fragment);

        static RendererOptions Fragment => new RendererOptions { IsFragment = true };
    }
}
