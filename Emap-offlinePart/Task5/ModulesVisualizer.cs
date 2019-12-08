using System;
using System.Collections.Generic;
using System.Reflection;

namespace Epam.Task5
{
    public static class ModulesVisualizer
    {
        public static IEnumerable<string> GetAssemblyInfo(string assemblyName)
        {
            if (String.IsNullOrEmpty(assemblyName))
                throw new ArgumentException("You didn't enter any name");

            Assembly assembly;

            try
            {
                assembly = Assembly.Load(AssemblyName.GetAssemblyName(assemblyName));
            }
            catch
            {
                throw new ArgumentException("Couldn't find such assembly");
            }

            var componentsList = new List<string>();

            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.IsAbstract)
                {
                    componentsList.Add("Abstract Class : " + type.Name);
                }
                else if (type.IsPublic)
                {
                    componentsList.Add("Public Class : " + type.Name);
                }
                componentsList.AddRange(GetMethods(type));         
            }
            return componentsList;
        }
        public static IEnumerable<string> GetMethods(Type type)
        {
            var componentsList = new List<string>();

            MemberInfo[] methodName = type.GetMethods();
            foreach (MemberInfo method in methodName)
            {
                if (method.ReflectedType.IsPublic)
                {
                    componentsList.Add("\tPublic Method : " + method.Name.ToString());
                }
                else
                {
                    componentsList.Add("\tNon-Public Method : " + method.Name.ToString());
                }
            }
            return componentsList;
        }
    }
}
