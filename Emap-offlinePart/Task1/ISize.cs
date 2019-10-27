using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1
{
    interface ISize
    {
        double Height { get; set; }
        double Width { get; set; }
        double Perimeter();
    }
}
