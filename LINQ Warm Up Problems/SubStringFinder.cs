using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Warm_Up_Problems
{
    public static class SubStringFinder
    {
        public static List<string> GetList(List<string> input)
        {
            return input.Where(s => s.ToLower().Contains("th")).ToList();
        }
    }
}
