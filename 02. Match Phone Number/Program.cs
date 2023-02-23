using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\ |\-)2{1}\1\d{3}\1\d{4}\b";
            Regex regex=new Regex(pattern);
            string inputline = Console.ReadLine();
            MatchCollection phonenumbers=regex.Matches(inputline);
           

            string[]result=phonenumbers.Select(x=>x.Value).ToArray();

            Console.WriteLine(string.Join(", ",phonenumbers));
        }
    }
}
