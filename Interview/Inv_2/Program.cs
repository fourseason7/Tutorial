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
            string filePath = @"D:\Temp\TestData";

            // file name


            string[] files = Directory.GetFiles(filePath, "*.fastq");
            //string[] files = Directory.GetFiles(filePath);
            foreach (string file in files)
            {
                //Console.WriteLine(item.ToString());

                //getData2(file, 1);

                if (file.Contains("_Read1"))
                {
                    GetContents(file, 1);
                }
                else if (file.Contains("_Read2"))
                {
                    GetContents(file, 2);
                }

            }


            string saveFile = @"d:\temp\test.txt";
            string writeText = string.Empty;
            foreach (string key in dictionary1.Keys)
            {
                writeText += "Sequence at the coordinates " + key + " " + dictionary1[key] + Environment.NewLine;
                Console.WriteLine("Sequence at the coordinates " + key + " " + dictionary1[key]);
            }
            //File.AppendAllText(saveFile, writeText, Encoding.Default);
            File.WriteAllText(saveFile, writeText);


            Console.ReadKey();
        }
        
        static void GetContents(string fileName, int filenumber)
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
        static void getData2( string fileName, int fileNumber)
        {
            StringBuilder fileContents = new StringBuilder();

            using (var sr = new StreamReader(fileName))
            {
                fileContents.Append(sr.ReadToEnd());
            }
        }
    }
}
