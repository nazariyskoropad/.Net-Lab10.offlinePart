using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7
{
    public class Matrix
    {
        public int[,] matrix = null;
        public int n { get; set; }
        public int m { get; set; }

        public Matrix(int _n, int _m)
        {
            n = _n;
            m = _m;
            matrix = new int[n, m];
            FillMatrix();
        }

        public void FillMatrix()
        {
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                }
            }
        }

        public int GetSumOfAllElements()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sum += matrix[i, j];
            return sum;
        }
    }
}
