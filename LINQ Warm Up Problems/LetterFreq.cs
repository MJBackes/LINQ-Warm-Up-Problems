using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Warm_Up_Problems
{
    public static class LetterFreq
    {
        private static List<string> GroupByLetter(string input)
        {
            List<string> letterCount = new List<string>();
            var groupedItem = 
            input.ToUpper().GroupBy(i => i).OrderBy(i => i.Key).ToList();
            foreach (var i in groupedItem)
            {
                letterCount.Add(i.Key.ToString());
                letterCount.Add(i.Count().ToString());
            }
            return letterCount;
        }
        public static string CompressString(string input)
        {
            List<string> letterCount = GroupByLetter(input);
            return String.Join("",letterCount.ToArray());
        }
    }
}
