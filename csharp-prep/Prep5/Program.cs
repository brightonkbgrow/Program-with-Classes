using System;

class Program
{
        static void Main(string[] args)
        {
            DisplayWelcome();
            string UserName = PromptUserName();
            int UserNumber = PromptUserNumber();

            int SquaredNumber = SquareNumber(UserNumber);
            DisplayResult(UserName, SquaredNumber);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int favnumber = int.Parse(number);
            return favnumber;
        }
        static int SquareNumber(int favnumber)
        {
            int squared = favnumber * favnumber;
            return squared;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, your favorite number squared is {square}");
        }
        

}




