using System.Threading;

namespace Epam.Task7
{
    public class Threads
    {
        System.Threading.Thread[] threads = null;

        Mutex _mutex = new Mutex();

        public int sum { get; set; } = 0;

        public int threadCount { get; set; }
        public Threads(int _threadCount)
        {
            threadCount = _threadCount;
            threads = new System.Threading.Thread[threadCount];
        }

        public int GetSumOfMatrixElements(Matrix matrix )
        {
            var pass = new PassParametersStruct();
            pass.matrix = matrix.matrix;
            pass.startColumn = 0;
            pass.processCount = threadCount;
            pass.currentProcessIndex = 0;
            pass.N = matrix.n;
            pass.M = matrix.m;

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(GetSumOfColumn));
                threads[i].Start(pass);
                pass.startColumn += matrix.m / threadCount;
                pass.currentProcessIndex++;
            }
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }

            return sum;
        }


        private void GetSumOfColumn(object _passParameters)
        {
            var pass = (PassParametersStruct)_passParameters;
            int _sum = 0;

            if (pass.currentProcessIndex == pass.processCount - 1)
            {
                for (int i = pass.startColumn; i < pass.M; i++)
                {
                    for (int j = 0; j < pass.N; j++)
                        _sum += pass.matrix[j, i];
                }
            }
            else
            {
                for (int i = pass.startColumn; i < pass.M / pass.processCount + pass.startColumn; i++)
                {
                    for (int j = 0; j < pass.N; j++)
                        _sum += pass.matrix[j, i];
                }
            }
            _mutex.WaitOne();
            sum += _sum;
            _mutex.ReleaseMutex();
        }
    }
}
