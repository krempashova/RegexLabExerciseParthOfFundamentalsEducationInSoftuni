using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesexisted = new List<string>();
            Dictionary<string, int> participants = new Dictionary<string, int>();
           
           

            string[] names = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);//gEOGREE,bILL,Tom,Ray
           
            foreach (var name in names)
            {
                namesexisted.Add(name);
            }

            string inputline;
            while((inputline=Console.ReadLine())!= "end of race")
            {
                string curname = string.Empty;
                int score = 0;
                //G4e@55or%6g6!68e!!@

               foreach (var ch in inputline)
                {
                    if(Char.IsLetter(ch))
                  {
                        curname += ch;
                  }
                    else if(Char.IsDigit(ch))

                    {
                        score += int.Parse(ch.ToString());

                    }

                }

                if (namesexisted.Contains(curname))
                {
                    if (!participants.ContainsKey(curname))
                    {
                        participants.Add(curname, score);
                    }

                   else
                    {
                        participants[curname] += score;
                    }
                }
            }

            var orderedparticipants = participants.OrderByDescending(X => X.Value);
            Console.WriteLine($"1st place: {orderedparticipants.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {orderedparticipants.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {orderedparticipants.ElementAt(2).Key}");


        }
    }
}
