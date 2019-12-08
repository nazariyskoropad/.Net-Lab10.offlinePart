using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task6
{
    public interface IActions<T> where T : class
    {
        void Move(Direction direction, int distance);
        void ChangeSize(Resize resize, int times);

        void PrintInfo();
    }
}
