using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedplanet = new List<string>();
            List<string> destoryedplanet = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryted = Console.ReadLine();
                string decryptedMessage = DecryptingMessage(encryted);
                string pattern = @"^[^\@\-\!\:\>]*?@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?:(?<population>\d+)[^\@\-\!\:\>]*?!(?<typeOfAttack>A|D)![^\@\-\!\:\>]*?\-\>(?<soldercount>\d+)[^\@\-\!\:\>]*?$";

                Regex regex = new Regex(pattern);
                Match match=regex.Match(decryptedMessage);
                if(match.Success)
                {
                    string planet = match.Groups["planet"].Value;

                    string typeOfAttack = match.Groups["typeOfAttack"].Value;
                    if(typeOfAttack=="A")
                    {
                        attackedplanet.Add(planet);
                    }
                    else if(typeOfAttack=="D")
                    {
                        destoryedplanet.Add(planet);
                    }
                        



                }
                


            }


            Console.WriteLine($"Attacked planets: {attackedplanet.Count}");
            if(attackedplanet.Count>0)
            {
                foreach (var item in attackedplanet.OrderBy(p=>p))
                {
                    Console.WriteLine($"-> {item}");
                }
                

            }
            Console.WriteLine($"Destroyed planets: {destoryedplanet.Count}");
            if(destoryedplanet.Count>0)
            {
                foreach (var item in destoryedplanet.OrderBy(p=>p))
                {
                    Console.WriteLine($"-> {item}");
                }
            }


        }

         static string DecryptingMessage(string encryted)
        {
            StringBuilder sb = new StringBuilder();
            int keycounter=DecryptingCountKey(encryted);
            foreach  (Char currch in encryted)
            {
                sb.Append((char)(currch - keycounter));
            }
            return sb.ToString();
        }

        static int  DecryptingCountKey(string encryted)
        {
            int keycounter = 0;
            foreach (char ch in encryted.ToLower()) 
            {
                if(ch=='s'|ch=='t'|ch=='a'|ch=='r')
                {
                   keycounter++;
                }
            }
            return keycounter;


        }
    }
}
