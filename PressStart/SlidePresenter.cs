using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PressStart
{
    class SlidePresenter
    {
        private Background _background;

        private readonly Slide[] _slides;

        private int _currentSlide = 0;

        private Slide CurrentSlide => _slides[_currentSlide];

        private ProgressTracker _progressIndicator;

        public SlidePresenter(Background background, IEnumerable<Slide> slides, ProgressTracker indicator)
        {
            _background = background;
            _slides = slides.ToArray();
            CurrentSlide.BeginShow(-1);
            _progressIndicator = indicator;
        }

        public void NextSlide()
        {
            if (CurrentSlide.HasInactiveFragments)
            {
                CurrentSlide.ActivateNextFragment();
                return;
            }

            if (_currentSlide == _slides.Count() - 1) return;
            CurrentSlide.BeginHide(-1);
            _currentSlide = Clamp(_currentSlide + 1);
            CurrentSlide.BeginShow(-1);
            _progressIndicator.UpdateProgress(_currentSlide);
        }

        public void PreviousSlide()
        {
            if (_currentSlide == 0) return;
            CurrentSlide.BeginHide(1);
            _currentSlide = Clamp(_currentSlide - 1);
            CurrentSlide.BeginShow(1);
            _progressIndicator.UpdateProgress(_currentSlide);
        }

        private int Clamp(int i) => MathHelper.Clamp(i, 0, _slides.Length - 1);

        internal void Update(GameTime gameTime)
        {
            _background.Update(gameTime, _slides.FirstOrDefault(s => s.IsTransitioning)?.Direction ?? -1);

            foreach (var slide in _slides)
                slide.Update(gameTime);
        }

        internal void Draw(SpriteBatch sb)
        {
            _background.Draw(sb);
            _progressIndicator.Draw(sb);
            foreach (var slide in _slides)
                slide.Draw(sb);
        }
    }
}
