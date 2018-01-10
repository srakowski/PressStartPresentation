using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PressStart.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PressStart
{
    class TextRenderer : Renderer
    {
        public override int Height => _lines.Length * LineHeight;

        public int Width => (int)_lines.Select(l => Font.MeasureString(l).X).Max();

        public Vector2 Origin => new Vector2(Width * 0.5f, Height * 0.5f);

        private int? _lineHeight = null;

        public SpriteFont Font { get; set; }

        private string _text;

        private int _alpha = 255;

        private int _blinkdir = -1;

        private float MyAlpha => (_alpha / 255f);

        public string Text
        {
            get => _text;
            set
            {
                _text = value ?? string.Empty;
                var words = new Queue<string>(_text.Split());
                var lines = new List<string>();
                var line = string.Empty;
                while (words.Any())
                {
                    var nextWord = words.Dequeue();
                    var maybeNewLine = $"{line}{(line.Length > 0 ? " " : "")}{nextWord}";
                    if (Font.MeasureString(maybeNewLine).X < (Stage.WIDTH - (Stage.MARGIN * 2)))
                    {
                        line = maybeNewLine;
                    }
                    else
                    {
                        lines.Add(line);
                        line = nextWord;
                    }
                }
                lines.Add(line);
                _lines = lines.ToArray();
            }
        }

        private string[] _lines { get; set; }

        public Color Color { get; set; } = Colors.Foreground;

        public int LineHeight
        {
            get => _lineHeight ?? (int)(Font.MeasureString("|").Y);
            set => _lineHeight = value;
        }

        public TextRenderer(RendererOptions opts, SpriteFont font, string text = "") : base(opts)
        {
            Font = font;
            Text = text;
        }

        public override void Update(GameTime gameTime)
        {
            if (!Options.Blink) return;
            _alpha = MathHelper.Clamp(_alpha + (int)(_blinkdir * gameTime.ElapsedGameTime.TotalSeconds * 300), 0, 255);
            if (_alpha == 0) _blinkdir = 1;
            if (_alpha == 255) _blinkdir = -1;
        }

        public override void Draw(SpriteBatch sb, int yOffset, int centerOffset)
        {
            int lineNumber = 0;
            foreach (var line in _lines)
            {
                if (!Options.Center)
                {
                    sb.DrawString(
                        spriteFont: Font,
                        text: line,
                        position: new Vector2(Stage.MARGIN, Stage.MARGIN) + new Vector2(0, (lineNumber++ * LineHeight) + yOffset),
                        color: new Color(Color, MathHelper.Min(Options.Alpha, MyAlpha)));
                }
                else
                {
                    sb.DrawString(
                        spriteFont: Font,
                        text: line,
                        position: new Vector2(Stage.WIDTH*0.5f, centerOffset - (LineHeight * 0.5f)) + new Vector2(-Origin.X, (lineNumber++ * LineHeight) + yOffset),
                        color: new Color(Color, MathHelper.Min(Options.Alpha, MyAlpha)));
                }
            }
        }
    }
}
