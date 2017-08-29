using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
           WorkWithFile();
            
        }
        static void WorkWithFile()
        {
            try
            {
              
                string path = @"TextFile.txt";

                using (StreamReader sr = new StreamReader(path))
                {

                    // string str = sr.ReadToEnd(). Replace(",", "").Replace(".", "").Replace(":", "").Replace(";", "").Replace("—","").Replace("\n","");
                    string str = sr.ReadToEnd().Replace("\n", "").Replace("\r", "");

                    char[] separators = { ',', '.', ':', ';', ' ', '-', '?', '!' };
                    List<string> words = new List<string>(str.Split(separators, StringSplitOptions.RemoveEmptyEntries));

                    Dictionary<string, int> KeyValue = new Dictionary<string, int>();

                    foreach (var v in words)
                    {

                        if (!KeyValue.ContainsKey(v))
                        {
                            KeyValue[v] = 1;
                        }
                        else
                        {
                            KeyValue[v]++;
                        }
                    }
                    foreach (var res in KeyValue)
                    {
                        Console.WriteLine(res.Key + " " + res.Value);
                    }
                }

            }
            
            catch
            {

            }
           
        }
    }
}
