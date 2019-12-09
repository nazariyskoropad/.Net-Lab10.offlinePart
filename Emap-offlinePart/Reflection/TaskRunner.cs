using Epam.Printer;

namespace Epam.Reflection
{
    public class TaskRunner
    {
        public void Main()
        {
            IPrinter _printer = new ConsolePrinter();
            Reflector reflector = new Reflector("printer");
            var types = reflector.GetAllTypes();
            var Fileprinter = reflector.CreateInstance("FilePrinter", null) ;
            _printer.PrintLine("Got instance of FilePrinter from reflection class");
        }
    }
}
