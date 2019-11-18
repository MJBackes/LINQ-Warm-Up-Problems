using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Warm_Up_Problems
{
    public static class DuplicateRemover
    {
        public static List<string> RemoveDupes(List<string> input)
        {
            return input.Distinct().ToList();
        }
    }
}
