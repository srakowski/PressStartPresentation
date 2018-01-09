namespace PressStart
{
    class RendererOptions
    {
        public bool IsFragment { get; set; } = false;
        public float Scale { get; set; } = 1f;
        public float Alpha { get; set; } = 1f;
    }

    static class RendererOptionsExtensions
    {
        public static RendererOptions Alpha(this RendererOptions self, float alpha)
        {
            self.Alpha = alpha;
            return self;
        }
    }
}
