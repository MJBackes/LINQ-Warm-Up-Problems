using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Warm_Up_Problems
{
    public static class GradeAverager
    {
        public static double AverageGrades(List<string> input)
        {
            List<string[]> lowestRemoved = new List<string[]>();
            input.ForEach(s => lowestRemoved.Add(OrderGrades(s)));
            List<string> averages = new List<string>();
            lowestRemoved.ForEach(s => averages.Add(AverageStringArray(s)));
            return double.Parse(AverageStringArray(averages.ToArray()));
        }
        private static string[] OrderGrades(string input)
        {
            var output = input.Split(',').OrderBy(i => int.Parse(i)).ToList();
            output.RemoveAt(0);
            return output.ToArray();
        }
        private static string AverageStringArray(string[] input)
        {
            double output = 0;
            foreach(string s in input)
            {
                output += double.Parse(s);
            }
            return (output / input.Length).ToString();
        }
    }
}
