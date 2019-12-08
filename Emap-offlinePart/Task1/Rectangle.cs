namespace Epam.Task1Part1
{
    public struct Rectangle: ISize, ICoordinates
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public double Perimeter()
        {
            return (this.Height+this.Width)*2;
        }
    }
}
