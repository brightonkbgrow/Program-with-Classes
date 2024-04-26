using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        string again = "YES";
        while (again == "YES")
        {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 1;
        int tries = 0;
        
        Console.WriteLine("Guess a number! ");

            while (!(guess == number))
            {   
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    tries = tries + 1;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    tries = tries + 1;
                }
                else
                {
                    Console.WriteLine("You've Guess It!");
                    Console.WriteLine($"You took {tries} tries");
                    Console.WriteLine($"Play Again? YES/NO");
                    again = Console.ReadLine();
                }
            }




        }
    }
}