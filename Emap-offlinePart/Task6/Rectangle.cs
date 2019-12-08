using System;
using Epam.Printer;

namespace Epam.Task6
{
    public class Rectangle : IActions<Rectangle>
    {
        public Rectangle() { }
        public Rectangle(int _X, int _Y, int _width, int _height)
        {
            X = _X;
            Y = _Y;
            Width = _width;
            Height = _height;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

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

        public void ChangeSize(Resize resize, int times)
        {
            if (times != 0)
            {
                switch (resize)
                {
                    case Resize.enlarge:
                        {
                            Width *= times;
                            Height *= times;
                            break;
                        }
                    case Resize.reduce:
                        {
                            Width /= times;
                            Height /= times;
                            break;
                        }
                }
            }
        }
        public void MakeWidther(int value)
        {
            if (value + Width <= 0)
                Width = 0;
            else
                Width += value;
        }

        public void MakeHigher(int value)
        {
            if (value + Height <= 0)
                Height = 0;
            else
                Height += value;
        }

        public static Rectangle NewRectangleByIntersectionOfTwoOthers(Rectangle R1, Rectangle R2)
        {
            //right down coordinate of rect1
            int X1 = R1.X + R1.Width;
            int Y1 = R1.Y - R1.Height;

            //right down coordinate of rect2
            int X2 = R2.X + R2.Width;
            int Y2 = R2.Y - R2.Height;

            var R3 = new Rectangle();
            R3.X = Math.Max(R1.X, R2.X);
            R3.Y = Math.Min(R1.Y, R2.Y);

            //right down coordinate of rect3
            int X = Math.Min(X1, X2);
            int Y = Math.Max(Y1, Y2);

            R3.Width = X - R3.X;
            R3.Height = R3.Y - Y;

            //rectangles dont intersect
            if (R3.Width <= 0 || R3.Height <= 0)
                return null;

            return R3;
        }
        public void PrintInfo()
        {
            IPrinter printer = new ConsolePrinter();
            printer.PrintLine("Left up coordinate of rectangle: (" + X + "," + Y + ")");
            printer.PrintLine("Width = " + Width + "\nHeight = " + Height);
        }
    }
}
