namespace Epam.Task6
{
    public class Task6Runner
    {
        public void Main()
        {
            var rect2 = new Rectangle(0,0,1,1);
            var rect3 = new Rectangle(3,3,2,2);
            var rect4 = Rectangle.NewRectangleByIntersectionOfTwoOthers(rect2, rect3);
            rect4.PrintInfo();


        }
    }
}
