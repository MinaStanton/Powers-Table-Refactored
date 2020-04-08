using System;

namespace Lab4_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Powers Table!\n");

            bool userContinue = true;
            while (userContinue)
            {
                DisplayPowersTable("Enter an integer:");
                userContinue = UserContinueChoice("\nWould you like to go again?", "y", "n");
            }

            Console.WriteLine("\nThanks for playing!");
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            if(UserInput == "")
            {
                return GetUserInput(message);
            }
            else
            {
                return UserInput;
            }
        }
        public static bool UserContinueChoice(string message, string option_true, string option_false)
        {
            string userChoice = GetUserInput(message).ToLower();
            if(userChoice == option_true)
            {
                return true;
            }
            else if(userChoice == option_false)
            {
                return false;
            }
            else
            {
                return UserContinueChoice(message, option_true, option_false);
            }
        }
        public static int GetInteger(string message)
        {
            string userInput = GetUserInput(message);
            try
            {
                int input = int.Parse(userInput);
                if(input < 1)
                {
                    return GetInteger(message);
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                return GetInteger(message);
            }
        }
        public static void DisplayPowersTable(string message)
        {
            int userNumber = GetInteger(message);
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-8} {1,4} {2,15}", "Number", "Squared", "Cubed"));
            Console.WriteLine("=================================");
            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(String.Format("{0,-8} {1,4} {2,17}", $"{i}", $"{i * i}", $"{i * i * i}"));
            }
        }
    }
}
