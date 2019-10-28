using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Epam.Task4
{
    public class xmlSerializer : ISerializer
    {
      
        IEnumerable<T> ISerializer.Deserialize<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            IEnumerable<T> serializedCollection;

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializedCollection = (List<T>)serializer.Deserialize(fs);

            }
            return serializedCollection;
        }

        void ISerializer.Serialize<T>(IEnumerable<T> collection, string path)
        {
            var type = typeof(T);

            if (!type.IsSerializable)
            {
                throw new ArgumentException($"Couldn't serialize {type.FullName}");
            }

            var serializer = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, collection);
            }
        }
    }
}
