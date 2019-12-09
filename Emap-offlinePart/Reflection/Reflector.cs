using System;
using System.Collections.Generic;
using System.Reflection;

namespace Epam.Reflection
{
    public class Reflector
    {
        Assembly assembly = null;
        public Reflector(string assemblyName)
        {
            try
            {
                assembly = Assembly.Load(assemblyName);
            }
            catch
            {
                throw new Exception("Couldnt find such an assembly");
            }
        }

        public IEnumerable<string> GetAllTypes()
        {
            if (assembly != null)
            {
                var typesList = new List<string>();
                Type[] types = assembly.GetTypes();
                foreach (var type in types)
                    typesList.Add(type.Name.ToString());
                return typesList;
            }
            else
            {
                return null;
            }
        }

        public object CreateInstance(string className, object[] parameters = null)
        {
            if (assembly != null)
            {
                object instance = null;
                Type[] types = assembly.GetTypes();

                Type typeToUse = null;
                foreach (var type in types)
                    if (className == type.Name)
                        typeToUse = type;
                if (typeToUse != null)
                {
                    ConstructorInfo ctor = typeToUse.GetConstructor(Type.EmptyTypes);
                    instance = ctor.Invoke(parameters);
                    return instance;
                }
            }
            return null;
        }
    }
}
