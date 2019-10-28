using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4
{
    public interface ISerializer
    {
        void Serialize<T>(IEnumerable<T> collection, string path);
        IEnumerable<T> Deserialize<T>(string path);
    }
}
