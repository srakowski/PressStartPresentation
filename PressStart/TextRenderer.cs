using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PressStart
{
    class TextRenderer : Renderer
    {
        public override int Height => _lines.Length * LineHeight;

        private int? _lineHeight = null;

        public SpriteFont Font { get; set; }

        private string _text;

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
                    if (Font.MeasureString(maybeNewLine).X < 980)
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

        public Color Color { get; set; } = Color.White;

        public int LineHeight
        {
            get => _lineHeight ?? (int)(Font.MeasureString("|").Y * 1.10f);
            set => _lineHeight = value;
        }

        public TextRenderer(RendererOptions opts, SpriteFont font, string text = "") : base(opts)
        {
            Font = font;
            Text = text;
        }

        public override void Draw(SpriteBatch sb, int yOffset)
        {
            int lineNumber = 0;
            foreach (var line in _lines)
            {
                sb.DrawString(Font, line, new Vector2(100f, 100f) + new Vector2(0, (lineNumber++ * LineHeight) + yOffset), Color);
            }
        }
    }
}
