using Epam.Printer;

namespace Epam.Task6
{
    public class Circle : IActions<Circle>
    {
        public Circle() { }
        public Circle(int _X, int _Y, int _radius)
        {
            X = _X;
            Y = _Y;
            Radius = _radius;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; set; }

        public void ChangeSize(Resize resize, int times)
        {
            if (times != 0)
            {
                switch (resize)
                {
                    case Resize.enlarge:
                        {
                            Radius *= times;
                            break;
                        }
                    case Resize.reduce:
                        {
                            Radius /= times;                         
                            break;
                        }
                }
            }
        }

        public void Move(Direction direction, int distance)
        {
            switch (direction)
            {
                case Direction.Up:
                    Y += distance;
                    break;

                case Direction.Down:
                    Y -= distance;
                    break;

                case Direction.Right:
                    X += distance;
                    break;

                case Direction.Left:
                    X -= distance;
                    break;
            }
        }

        public void PrintInfo()
        {
            IPrinter printer = new ConsolePrinter();
            printer.PrintLine("Cootdinate of centre of circle (" + X + "," + Y + ")");
            printer.PrintLine("Radius= " + Radius);
        }
    }
}
