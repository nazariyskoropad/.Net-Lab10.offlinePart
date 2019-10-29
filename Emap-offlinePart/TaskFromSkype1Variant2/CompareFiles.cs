using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TaskFromSkype1Variant2
{
    public static class CompareFiles
    {
        public static IEnumerable<string> GetUniqueFiles(List<string> list1, List<string> list2)
        {         
            var fileList = list1.Except(list2).Concat(list2.Except(list1));
            return fileList;
        }
        public static IEnumerable<string> GetCommonFiles(List<string> list1, List<string> list2)
        {
            var fileList = list1.Intersect(list2);
            return fileList;
        }
    }
}
