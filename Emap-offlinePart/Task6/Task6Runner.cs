using System;

namespace Epam.Task6
{
    public class Task6Runner
    {
        public void Main()
        {
            var rect1 = new Rectangle(3, 4, 5, 7);
            rect1.MakeHigher(-1);
            rect1.MakeWidther(1);
            rect1.Move(Direction.Up, 2);
            rect1.ChangeSize(Resize.enlarge, 2);
            rect1.PrintInfo();

            Console.WriteLine();
            Rectangle.PrintInfo(rect1);

        }
    }
}
