using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Printer;
using Epam.Reader;

namespace Epam.Task1Part1
{
    public class Task1Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();

            printer.PrintLine("Task 1.1");
            try
            {
                var p1 = ReadPerson();

                printer.PrintLine("Enter the age to compare");
                int ageToCompare = int.Parse(reader.ReadLine());
                if (ageToCompare <= 0)
                    throw new Exception("Age must be bigger then 0");

                string str1 = p1.isOlderOrYounger(ageToCompare);
                printer.PrintLine(str1);
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            printer.PrintLine("________________________________________");

            try
            {
                var rect = ReadRectangle();
                double perimeter1 = rect.Perimeter();
                printer.PrintLine("Perimiter = " + perimeter1);
            }
            catch(Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static Rectangle ReadRectangle()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();
            printer.PrintLine("Enter width");
            double width = Convert.ToDouble(reader.ReadLine());

            printer.PrintLine("Enter height");
            double height = Convert.ToDouble(reader.ReadLine());

            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and height must be positive numbers");
            return new Rectangle
            {
                Width = width,
                Height = height,
                X = 0,
                Y = 0
            };
           
        }
        public static Person ReadPerson()
        {
            IPrinter printer = new ConsolePrinter();
            IReader reader = new ConsoleReader();

            printer.PrintLine("Enter name: ");
            string name = reader.ReadLine();

            printer.PrintLine("Enter surname: ");
            string surname = reader.ReadLine();


            printer.PrintLine("Enter age: ");
            int age = Convert.ToInt32(reader.ReadLine());

            if (age <= 0)
                throw new Exception("Age must be bigger then 0");

            return new Person
            {
                Name = name,
                Surname = surname,
                Age = age
            };
        }
    }
}
