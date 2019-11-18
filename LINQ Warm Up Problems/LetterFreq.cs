using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Warm_Up_Problems
{
    public static class LetterFreq
    {
        public static string SortAlphabetically(string input)
        {
            char[] letters = input.ToUpper().ToCharArray();
            letters = letters.OrderBy(c => c).ToArray();
            return ArrayToString(letters);
        }
        public static List<int> GroupByLetter(string input)
        {
            List<int> letterCount = new List<int>();
            var groupedItem = input.GroupBy(i => i).ToList();
            foreach (var i in groupedItem) {
                letterCount.Add(i.Count());
                    }
            return letterCount;
        }
        public static string CompressString(string input)
        {
            input = SortAlphabetically(input);
            List<int> letterCount = GroupByLetter(input);
            input = ArrayToString(RemoveDupes(input));
            char[] letters = input.ToCharArray();
            StringBuilder output = new StringBuilder("");
            for(int i = 0; i < letterCount.Count; i++)
            {
                output.Append(letters[i]);
                output.Append(letterCount[i]);
            }
            return output.ToString();
        }
        public static string ArrayToString(char[] input)
        {
            StringBuilder output = new StringBuilder("");
            foreach(char c in input) { output.Append(c); }
            return output.ToString();
        }
        public static char[] RemoveDupes(string input)
        {
            return input.ToCharArray().Distinct().ToArray();
        }
    }
}
