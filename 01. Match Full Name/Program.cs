using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex= new Regex(pattern);
            string inputLine = Console.ReadLine();
            MatchCollection matchesnames=regex.Matches(inputLine);
            foreach (Match match in matchesnames)
            {
                Console.Write(match.Value+" ");
            } 
        }
    }
}
