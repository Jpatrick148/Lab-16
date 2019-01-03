using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Lab_16
{
    public class CountriesTextFile
    {
        private string path;
        private StreamReader sr;
        private StreamWriter sw;

        public  CountriesTextFile(string path)
        {
            this.path = path;  
        }

        public string ReadFile(string path)
        {
            sr = new StreamReader(path);
            try
            {
                string output = sr.ReadToEnd();
                Close();
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HelpLink);
                Close();
                return "No New Lines Found";
            }
        }

        public void WriteToFile(string input)
        {
            sw = new StreamWriter(path);
            sw.Write(input);
            Close();
        }
        public void Close()
        {
            
            if (sr != null)
            {
                sr.Close();
            }

            if (sw != null)
            {
                sw.Close();
            }
        }

    }
}