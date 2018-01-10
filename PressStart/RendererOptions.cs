namespace PressStart
{
    class RendererOptions
    {
        public bool IsFragment { get; set; } = false;
        public float Scale { get; set; } = 1f;
        public float Alpha { get; set; } = 1f;
        public string SoundEffect { get; set; } = null;
        public bool Center { get; set; }
        public bool AutoNextFragment { get; set; }
    }

    static class RendererOptionsExtensions
    {
        public static RendererOptions Alpha(this RendererOptions self, float alpha)
        {
            self.Alpha = alpha;
            return self;
        }

        public static RendererOptions Center(this RendererOptions self, bool center = true)
        {
            self.Center = center;
            return self;
        }

        public static RendererOptions AutoNextFragment(this RendererOptions self)
        {
            self.AutoNextFragment = true;
            return self;
        }
    }
}
