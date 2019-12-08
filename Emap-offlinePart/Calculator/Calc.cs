using System;

namespace Epam.Calc
{
    public class Calculator
    {
        public ICalcReader reader;
        public Calculator(Source source)
        {
            switch(source)
            {
                case Source.Console:
                    {
                        reader = new ConsoleCalcReader();
                        break;
                    }
                case Source.File:
                    {
                        reader = new FileCalcReader();
                        break;
                    }
            }
        }        
        public double calculate(int a, int b, Operation operation)
        {
            switch(operation)
            {
                case Operation.Plus:
                    {
                        return a + b;
                    }
                case Operation.Minus:
                    {
                        return a - b;
                    }
                case Operation.Multiply:
                    {
                        return a * b;
                    }
                case Operation.Divide:
                    {
                        if (b != 0)
                            return a / b;
                        else
                        {
                            throw new DivideByZeroException();                           
                        }
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
