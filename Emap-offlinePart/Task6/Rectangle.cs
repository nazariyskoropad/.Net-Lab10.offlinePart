using System;
using System.Collections.Generic;
using System.Text;
using Epam.Printer;

namespace Epam.Task6
{
    public class Rectangle
    {
        public Rectangle() { }
        public Rectangle(int _X, int _Y, int _width, int _height)
        {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }

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
                            width *= times;
                            height *= times;
                            break;
                        }
                    case Resize.reduce:
                        {
                            width /= times;
                            height /= times;
                            break;
                        }
                }
            }
        }
        public void MakeWidther(int value)
        {
            if (value + width <= 0)
                width = 0;
            else
                width += value;
        }

        public void MakeHigher(int value)
        {
            if (value + height <= 0)
                height = 0;
            else
                height += value;
        }

        public static Rectangle NewRectangleByIntersectionOfTwoOthers(Rectangle R1, Rectangle R2)
        {
            //right down coordinate of rect1
            int X1 = R1.X + R1.width;
            int Y1 = R1.Y - R1.height;

            //right down coordinate of rect2
            int X2 = R2.X + R2.width;
            int Y2 = R2.Y - R2.height;

            var R3 = new Rectangle();
            R3.X = Math.Max(R1.X, R2.X);
            R3.Y = Math.Min(R1.Y, R2.Y);

            //right down coordinate of rect3
            int X = Math.Min(X1, X2);
            int Y = Math.Max(Y1, Y2);

            R3.width = X - R3.X;
            R3.height = R3.Y - Y;

            //rectangles dont intersect
            if (R3.width <= 0 || R3.height <= 0)
                return null;

            return R3;
        }
        public static void PrintInfo(Rectangle R)
        {
            IPrinter printer = new ConsolePrinter();
            printer.PrintLine("Left up coordinate: (" + R.X + "," + R.Y + ")");
            printer.PrintLine("Width = " + R.width + "\nHeight = " + R.height);
        }

        public void PrintInfo()
        {
            IPrinter printer = new ConsolePrinter();
            printer.PrintLine("Left up coordinate: (" + X + "," + Y + ")");
            printer.PrintLine("Width = " + width + "\nHeight = " + height);
        }
    }
}
