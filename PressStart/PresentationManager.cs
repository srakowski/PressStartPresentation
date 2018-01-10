using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PressStart.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PressStart
{
    class PresentationManager : DrawableGameComponent
    {
        private SpriteBatch _sb;

        private Func<Background> _backgroundFactory;

        private Func<IEnumerable<Slide>> _deckFactory;

        private Func<int, ProgressTracker> _trackerFactory;

        private SlidePresenter _slidePresenter;

        public PresentationManager(Game game,
            Func<Background> backgroundFactory,
            Func<IEnumerable<Slide>> deckFactory,
            Func<int, ProgressTracker> trackerFactory) : base(game)
        {
            _backgroundFactory = backgroundFactory;
            _deckFactory = deckFactory;
            _trackerFactory = trackerFactory;
        }

        public override void Initialize()
        {
            base.Initialize();
            _sb = new SpriteBatch(Game.GraphicsDevice);
            var deck = _deckFactory.Invoke();
            _slidePresenter = new SlidePresenter(_backgroundFactory.Invoke(), deck, _trackerFactory.Invoke(deck.Count()));
        }

        protected override void LoadContent()
        {
            // move this out of here...
            Fonts.Load(Game.Content);
            Presentation.PresentationContent.Load(Game.Content);
        }

        public override void Update(GameTime gameTime)
        {
            Input.Update();
            base.Update(gameTime);
            if (Input.WasButtonPressed(Buttons.RightTrigger) || Input.WasKeyPressed(Keys.Right))
                _slidePresenter.NextSlide();
            else if (Input.WasButtonPressed(Buttons.LeftTrigger) || Input.WasKeyPressed(Keys.Left))
                _slidePresenter.PreviousSlide();
            _slidePresenter.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Game.GraphicsDevice.Clear(Colors.Background);
            _slidePresenter.Draw(_sb);
        }
    }
}
