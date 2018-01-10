using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PressStart
{
    class ImageRenderer : Renderer
    {
        private Texture2D Image { get; set; }

        public override int Height => (int)(Image.Height * Options.Scale);

        public ImageRenderer(RendererOptions options, Texture2D image) : base(options)
        {
            Image = image;
        }

        public override void Draw(SpriteBatch sb, int yOffset, int centerOffsetY)
        {
            var scale = new Vector2(Options.Scale, Options.Scale);
            sb.Draw(
                texture: Image,
                position: new Vector2(Stage.WIDTH * 0.5f, yOffset + centerOffsetY),
                scale: scale,
                origin: new Vector2(Image.Width * 0.5f, 0f),
                color: Color.White);
        }
    }
}
