using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;



namespace Epam.Task4
{
    public class BinSerializer : ISerializer
    {  
        IEnumerable<T> ISerializer.Deserialize<T>(string path)
        {
            BinaryFormatter serializer = new BinaryFormatter();
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

            BinaryFormatter serializer = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, collection);
            }
        }
    }
}
