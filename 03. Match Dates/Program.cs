using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
             Regex regex=new Regex(pattern);
            string inputlinee=Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(inputlinee);
            foreach (Match match in matchCollection)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;


                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
