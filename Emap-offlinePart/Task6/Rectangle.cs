using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Task6
{
    public class Rectangle
    {
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
                        width *= times;
                        height *= times;
                        break;
                    case Resize.reduce:
                        width /= times;
                        height /= times;
                        break;
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


            return null;
        }
        public static void PrintInfo(Rectangle R)
        {
            Console.WriteLine("Left up coordinate: (" + R.X + "," + R.Y + ")");
            Console.WriteLine("Width = " + R.width + "\nHeight = " + R.height);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Left up coordinate: (" + X + "," + Y + ")");
            Console.WriteLine("Width = " + width + "\nHeight = " + height);
        }
    }
}
