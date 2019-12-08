namespace Epam.Task1Part1
{
    interface ISize
    {
        double Height { get; set; }
        double Width { get; set; }
        double Perimeter();
    }
}
