using System;

namespace Lab_16
{
    public class CountriesApp
    {
        public CountriesApp()
        {

        }

        private string FilePath;

        public string UserMenu()
        {

            FilePath = @"C:\Users\JP\source\repos\Lab 16\Lab 16\countries.txt";
            int input;

            Console.WriteLine("Countries List App! \n 1: See the list. \n 2: Add a country. \n 3: Exit.");
            bool checkParse = int.TryParse(Console.ReadLine(),out input);
            input--;
            while (!checkParse)
            {
                Console.WriteLine("Please pick 1, 2 or 3.");
                UserMenu();
            }

            switch (input)
            {
                    case 0:
                        CountriesTextFile read = new CountriesTextFile(FilePath);
                        string s = read.ReadFile(FilePath);
                        return s;
                        break;

                    case 1:
                        do
                        {
                            CountriesTextFile baseFile = new CountriesTextFile(FilePath);
                            string a = baseFile.ReadFile(FilePath);

                            CountriesTextFile Write = new CountriesTextFile(FilePath);
                            Console.WriteLine("Enter the country you would like to add. ");
                            string userC = Console.ReadLine();
                            Write.WriteToFile(a + '\n' + userC); 

                        } while (Continue());
                        break;

                    case 2:
                        return "All done.";
                        break;
                    default:
                        return UserMenu();
                    break;
            }
            return "Goodbye!";
        }

        public void DeleteCountry()
        {
            CountriesTextFile baseFile = new CountriesTextFile(FilePath);
            string a = baseFile.ReadFile(FilePath);

            Console.WriteLine("Enter a country to delete");
            string input = Console.ReadLine();

            // a.Split(input,input.Length);

        }

        public static bool Continue()
        {
            Console.WriteLine("Add another? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                Console.Clear();
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else Console.WriteLine("Please Try Again.");
            return Continue();
        }


    }
}