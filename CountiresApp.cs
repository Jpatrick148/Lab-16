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
            while (checkParse)
            {
                switch (input)
                {
                    case 0:
                        CountriesTextFile Read = new CountriesTextFile(FilePath);
                        return Read.ReadFile(FilePath);//ADD THE LIST METHOD CALL HERE
                        break;

                    case 1:
                        //return //PUT ADD COUNTRY METHOD CALL HERE
                        break;

                    case 2:
                       
                        break;
                    default:
                        return UserMenu();
                    break;
                }
            }

            return "test";
        }


        public static bool Continue()
        {
            Console.WriteLine("Back to the main menu? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
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