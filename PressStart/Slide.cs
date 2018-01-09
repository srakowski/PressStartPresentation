﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

        internal void Update(GameTime gameTime)
        {
            if (_slideState == SlideState.TransitionOn)
            {
                _pos += (_transitionDir * 20);
                if (_pos == 0) _slideState = SlideState.Active;
            }
            else if (_slideState == SlideState.TransitionOff)
            {
                _pos += (_transitionDir * 20);
                if (Math.Abs(_pos) == BOUNDARY) _slideState = SlideState.Inactive;
            }
        }

        internal void Draw(SpriteBatch sb)
        {
            if (_slideState == SlideState.Inactive)
                return;

            int yOffset = 0;

            sb.Begin(transformMatrix: Matrix.Identity * Matrix.CreateTranslation(new Vector3((_pos / 100f) * 1280f, 0f, 1f)));
            foreach (var renderer in _renderers.Where(r => r.IsActive))
            {
                renderer.Draw(sb, yOffset);
                yOffset += renderer.Height;
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

        internal Slide Image(string path, RendererOptions opts = null)
        {
            // todo get PresentationContent out of here..
            _renderers.Add(new ImageRenderer(opts, Presentation.PresentationContent.Images[path]));
            return this;
        }

        internal void ActivateNextFragment()
        {
            _renderers.FirstOrDefault(r => !r.IsActive)?.Activate();
        }
    }
}
