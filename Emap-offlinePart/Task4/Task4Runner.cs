using System;
using System.Collections.Generic;
using Epam.Printer;

namespace Epam.Task4
{
    public class Task4Runner
    {
        public void Main()
        {
            IPrinter printer = new ConsolePrinter();

            var carsList = GetCars();

            try
            {
                ISerializer binSerializer = new BinSerializer();
                binSerializer.Serialize(carsList, "cars.bin");
                var carListBin = binSerializer.Deserialize<Car>("cars.bin");
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            try
            {
                ISerializer xmlserializer = new xmlSerializer();
                xmlserializer.Serialize(carsList, "cars.xml");
                var carListXML = xmlserializer.Deserialize<Car>("cars.xml");
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            try
            {
                ISerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(carsList, "cars.json");
                var carListJSON = jsonSerializer.Deserialize<Car>("cars.json");
            }
            catch (Exception ex)
            {
                printer.PrintLine(ex.Message);
            }

            printer.PrintLine("All objects were successfully serialized");
        }  
        public List<Car> GetCars()
        {
            return new List<Car>
            {
               new Car(123, 100000, 1, 5),
               new Car(124, 200000, 2, 6),
               new Car(125, 300000, 3, 7)
            };
        }
    }
}
