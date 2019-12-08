namespace Epam.Printer
{
    public interface IPrinter
    {
        void PrintLine(string text);
        void Print(string text);
        void Clear();
    }
}
