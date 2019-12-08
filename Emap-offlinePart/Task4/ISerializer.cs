using System.Collections.Generic;

namespace Epam.Task4
{
    public interface ISerializer
    {
        void Serialize<T>(IEnumerable<T> collection, string path);
        IEnumerable<T> Deserialize<T>(string path);
    }
}
