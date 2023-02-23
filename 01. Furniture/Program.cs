using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < string >collectionNames= new List<string>();
            double totalprice = 0;
            string pattern=@"^\>>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);
            string input;
            ///>>sOFA<<PRICE!QUANTITY
            while((input = Console.ReadLine()) !="Purchase")
            {
                Match match=regex.Match(input);
                if(match.Success) 
                
                {
                    string furnitureName = match.Groups["name"].Value;
                    double price =double.Parse( match.Groups["price"].Value);
                    int quntity = int.Parse(match.Groups["quantity"].Value);

                    collectionNames.Add(furnitureName);

                    totalprice += price * quntity;

                }   


            }

            Console.WriteLine("Bought furniture:");
            foreach (string item in collectionNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalprice:f2}");
        }
    }
}