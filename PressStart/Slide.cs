using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace PressStart
{
    class Slide
    {
        public bool HasInactiveFragments => _renderers.Any(r => !r.IsActive && r.IsFragment);

        private const int BOUNDARY = 200;

        public int Direction => _transitionDir;

        public bool IsTransitioning => _slideState == SlideState.TransitionOn;

        enum SlideState
        {
            Inactive,
            TransitionOn,
            Active,
            TransitionOff,
        }

        private int _pos = BOUNDARY;

        private int _transitionDir = 3;

        private List<Renderer> _renderers = new List<Renderer>();

        private SlideState _slideState = SlideState.Inactive;

        private event EventHandler OnActivate;

        private event EventHandler OnDeactivate;

        internal void Update(GameTime gameTime)
        {
            if (_slideState == SlideState.TransitionOn)
            {
                _pos += (_transitionDir * 20);
                if (_pos == 0) _slideState = SlideState.Active;
                OnActivate?.Invoke(this, null);
            }
            else if (_slideState == SlideState.TransitionOff)
            {
                _pos += (_transitionDir * 20);
                if (Math.Abs(_pos) == BOUNDARY) _slideState = SlideState.Inactive;
                OnDeactivate?.Invoke(this, null);
            }
        }

        internal void Draw(SpriteBatch sb)
        {
            if (_slideState == SlideState.Inactive)
                return;

            int yOffset = 0;

            sb.Begin(blendState: BlendState.NonPremultiplied,
                transformMatrix: Matrix.Identity * Matrix.CreateTranslation(new Vector3((_pos / 100f) * Stage.WIDTH, 0f, 1f)));
            var totH = _renderers.Select(r => r.Height).Sum();
            foreach (var renderer in _renderers.Where(r => r.IsActive))
            {
                renderer.Draw(sb, yOffset, (int)((Stage.HEIGHT * 0.5f) - (totH * 0.5f)));
                yOffset += (int)(renderer.Height + 30f);
            }
            sb.End();
        }

        internal void BeginHide(int dir)
        {
            _transitionDir = dir;
            _slideState = SlideState.TransitionOff;
        }

        internal void BeginShow(int dir)
        {
            _transitionDir = dir;
            _slideState = SlideState.TransitionOn;
        }

        internal Slide Title(string text, RendererOptions opts = null)
        {
            _renderers.Add(new TextRenderer(opts, Fonts.H1, text));
            return this;
        }

        internal Slide SubTitle(string text, RendererOptions opts = null)
        {
            _renderers.Add(new TextRenderer(opts, Fonts.H2, text));
            return this;
        }

        internal Slide SubText(string text, RendererOptions opts = null)
        {
            _renderers.Add(new TextRenderer(opts, Fonts.SubText, text));
            return this;
        }

        internal Slide Image(string path, RendererOptions opts = null)
        {
            // todo get PresentationContent out of here..
            _renderers.Add(new ImageRenderer(opts, Presentation.PresentationContent.Images[path]));
            return this;
        }

        internal Slide Song(string path)
        {
            OnActivate += (s, e) => MediaPlayer.Play(Presentation.PresentationContent.Songs[path]);
            OnDeactivate += (s, e) => MediaPlayer.Stop();
            return this;
        }

        internal void ActivateNextFragment()
        {
            _renderers.FirstOrDefault(r => !r.IsActive)?.Activate();
            while (_renderers.FirstOrDefault(r => !r.IsActive && r.AutoNext)?.Activate() ?? false) ;
        }
    }
}
