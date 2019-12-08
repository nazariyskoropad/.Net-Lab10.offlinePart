using System.Collections.Generic;
using System.IO;



namespace Epam.Task3
{
    public static class FileFinder
    {
        public static IEnumerable<string> findAllFiles(string partName)
        {
            var _partName = string.Format("*{0}*.txt", partName);

            //var path = ConfigurationManager.AppSettings["Path"];
            var dir = new DirectoryInfo(@"D:\1univer");

            var fileList = new List<string>();

            foreach (var file in dir.GetFiles(_partName, SearchOption.AllDirectories))
            {
                fileList.Add(file.FullName);
            }

            return fileList;
        }
    }
}
