namespace Mobile
{
    public class Display
    {
        private double size;
        private ulong numberColors;

        public Display(double displaySize, ulong displayColors)
        {
            this.Size = displaySize;
            this.Colors = displayColors;
        }

        public double Size { get; set; }
        public ulong Colors { get; set; }

    }
}
