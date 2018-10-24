using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {

            CountriesApp menuApp = new CountriesApp();
            bool check = false;
            do
            {
                Console.WriteLine(menuApp.UserMenu());
                
                Console.WriteLine("Back to the menu? Y/N");
                string input = Console.ReadLine().ToLower();
                Console.Clear();
                if (input == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                
            } while (check);

            Console.ReadLine();

        }
    }
}
