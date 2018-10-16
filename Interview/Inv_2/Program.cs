using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inv_2
{
    class Program
    {
        static Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
        //static Dictionary<string, string> dictionary2 = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            string filePath = @"d:\Test";

            // file name


            //string[] files = Directory.GetFiles(filePath, "*.fastq");
            string[] files = Directory.GetFiles(filePath);
            foreach (string item in files)
            {
                //Console.WriteLine(item.ToString());

                if (item.Contains("_Read1"))
                {
                    getData(item, 1);
                }
                else if (item.Contains("_Read2"))
                {
                    getData(item, 2);
                }

            }

            foreach (string key in dictionary1.Keys)
            {
                Console.WriteLine("Sequence at the coordinates " + key + " " + dictionary1[key]);
            }

            Console.ReadKey();
        }

        static void getData(string fileName, int filenumber)
        {
            // line 1 : key 1, 5, 9, 13 - using mod 4
            // line 2 : value 2, 6, 10, 14 - using mod 4
            string key = string.Empty;
            string value = string.Empty;

            string xvalue = string.Empty;
            string yvalue = string.Empty;

            foreach (var item in File.ReadLines(fileName)
                                        .Select((text, index) => new {text, linenumber = index + 1}))
                                  
            {
                if ((item.linenumber % 4) == 1) //key
                {
                    key = item.text;

                    key = key.Substring(0, key.IndexOf(" "));
                    yvalue = key.Substring(key.LastIndexOf(":" )+ 1);
                    key = key.Substring(0, key.LastIndexOf(":"));
                    xvalue = key.Substring(key.LastIndexOf(":") + 1);

                    key = string.Format("{0}:{1}", xvalue, yvalue);

                }
                else if ((item.linenumber % 4) == 2) // value
                {
                    value = item.text;
                }
                else if((item.linenumber % 4) == 0 ) //value finish
                {
                    if (filenumber == 1)
                    {
                        if (!dictionary1.ContainsKey(key))
                        {
                            dictionary1.Add(key, value);
                        }
                    }
                    else if (filenumber == 2)
                    {
                        if (!dictionary1.ContainsKey(key))
                        {
                            dictionary1.Add(key, value);
                        }
                        else
                        {
                            dictionary1[key] += value;
                        }
                    }
                }
            }
        }

    }
}
