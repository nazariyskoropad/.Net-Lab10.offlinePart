using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Epam.Task4
{
    public class JsonSerializer : ISerializer
    {
        IEnumerable<T> ISerializer.Deserialize<T>(string path)
        {
            string jsonString = File.ReadAllText(path);

            var collection = JsonConvert.DeserializeObject<IEnumerable<T>>(jsonString);

            return collection;
        }

        void ISerializer.Serialize<T>(IEnumerable<T> collection, string path)
        {
            var type = typeof(T);

            if (!type.IsSerializable)
            {
                throw new ArgumentException($"Couldn't serialize {type.FullName}");
            }

            string jsonString= JsonConvert.SerializeObject(collection, Formatting.Indented);

            File.WriteAllText(path, jsonString);
        }
    }
}
