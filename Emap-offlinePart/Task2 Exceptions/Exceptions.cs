using System;

namespace Epam.Task2
{
    public static class Exceptions
    {
        public static void GenerateStackOverFlowException()
        {
            //This code generates StackOverFlowException but you cant catch it

            //_ = func(0);

            //int func(int a)
            //{
            //    return func(a);
            //}

            //Excplicitly throwing StackOverflowException
            throw new StackOverflowException();
        }

        public static void GenerateIndexOutOfRangeException()
        {
            int[] array = new int[1];

            _ = array[1];

        }
        public static void DoSomeMath(int a, int b)
        {
            if (a < 0)
                throw new ArgumentException("Parameter a should be greater than 0", "a");
            if (b > 0)
                throw new ArgumentException("Parameter b should be less than 0", "b");
            
        }
    }
}
