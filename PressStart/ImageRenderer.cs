using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    class ImageRenderer : Renderer
    {
        private Texture2D Image { get; set; }

        public override int Height => Image.Height;

        public ImageRenderer(RendererOptions options, Texture2D image) : base(options)
        {
            Image = image;
        }

        public override void Draw(SpriteBatch sb, int yOffset)
        {
            var scale = new Vector2(Options.Scale, Options.Scale);
            sb.Draw(
                texture: Image,
                position: new Vector2(640f, 360f),
                scale: scale,
                origin: new Vector2(Image.Width * 0.5f, Image.Height * 0.5f),
                color: Color.White);
        }
    }
}
