using System;
using System.Collections.Generic;
using System.IO;


namespace Epam.Task3
{
    public static class DirectoryVisualizer
    {
        public static IEnumerable<string> GetFilesFromDirectory(string inputDirectory)
        {
            return GetFilesFromDirectory(inputDirectory, 2);
        }

        public static IEnumerable<string> GetFilesFromDirectory(string inputDirectory, int depth)
        {
            if (string.IsNullOrEmpty(inputDirectory))
            {
                throw new ArgumentException("inputDirectory cannot be null or empty", "inputDirectory");
            }

            var fileList = new List<string>();
            var dir = new DirectoryInfo(inputDirectory);
            if (!dir.Exists)
                throw new ArgumentException("Couln't find this directory");
            
            var dashes = new char[2 - depth];
            for (int i = 0; i < 2 - depth; i++)
                dashes[i] = '-';

            // fileList.Add(new string(dashes) + dir.FullName.ToString());
            fileList.Add(dir.FullName.ToString());

            foreach (var file in dir.GetFiles())
                // fileList.Add(new string(dashes) + "-" + file.Name);
                fileList.Add(file.Name);

            foreach (var subdir in dir.GetDirectories())
                fileList.AddRange(GetFilesFromDirectory(subdir.FullName, --depth));

            return fileList;

        }
    }
}
