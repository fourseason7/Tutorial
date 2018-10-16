using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Inv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lists = new List<string>();
            //lists.Add("CCGGATGGCGGCGTCACTGTC");
            //lists.Add("CCGGATGGCGGCGTCGCTGTC");
            //lists.Add("CGGGTTGGCGGCGTCGCTGTC");
            //lists.Add("CAGGTTGGCGGCGTCACTGTC");
            //lists.Add("CTGGTTGGTGGCGTCACTGTC");
            //lists.Add("CGGGTTGGTGGCGTCGCTGTC");
            //lists.Add("CGGGGTGGTGGCGTCGCTGTC");

            List<string> lists = new List<string>();
            var dataFile = File.ReadAllLines(@"d:\Test\seqdata.txt");
            foreach (var item in dataFile)
            {
                lists.Add(item);
            }

            string strToMatch = "CSGGWTGGYGGCGTCRCTGTC";

            strToMatch = strToMatch.Replace("M", "[AC]");
            strToMatch = strToMatch.Replace("R", "[AG]");
            strToMatch = strToMatch.Replace("W", "[AT]");
            strToMatch = strToMatch.Replace("S", "[CG]");
            strToMatch = strToMatch.Replace("Y", "[CT]");
            strToMatch = strToMatch.Replace("K", "[GT]");

            Console.WriteLine("String to Match: " + strToMatch);


            foreach (string item in lists)
            {
                if (Regex.IsMatch(item, strToMatch))
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
