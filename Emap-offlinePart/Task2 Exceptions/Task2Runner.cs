using System;
using Epam.Printer;
using Epam.Reader;

namespace Epam.Task2
{
    public class Task2Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();
            try
            {
                Exceptions.GenerateStackOverFlowException();
            }
            catch(StackOverflowException ex)
            {
                printer.PrintLine(ex.Message);
                try
                {
                    Exceptions.GenerateIndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException e)
                {
                    printer.PrintLine(e.Message);
                }
            }

            try
            {
                int a, b;

                Console.Write("\nEnter a: ");
                a = Convert.ToInt32(reader.ReadLine());

                Console.Write("Enter b: ");
                b = Convert.ToInt32(reader.ReadLine());

                Exceptions.DoSomeMath(a, b);
                printer.PrintLine("No exceptions generated");
            }
            catch (ArgumentException ex) when (ex.ParamName == "a")
            {
                printer.PrintLine(ex.Message);
            }
            catch (ArgumentException ex) when (ex.ParamName == "b")
            {
                printer.PrintLine(ex.Message);
            }
            catch (Exception ex)
            {
                printer.PrintLine("A and B must be integers\n" + ex.Message);
            }

            Console.ReadKey();
        }

        static void DoSomeMath(int a, int b)
        {
            if (a < 0)
                throw new ArgumentException("Parameter should be greater than 0", "a");
            if (b > 0)
                throw new ArgumentException("Parameter should be less than 0", "b");
        }

        static void IndexOutOfRangeMethod()
        {
            int[] array = new int[5];
            array[7] = 5;
        }

        static int StackOverflowMethod()
        {
          //  throw new StackOverflowException();
            return StackOverflowMethod();
        }
    }
}
