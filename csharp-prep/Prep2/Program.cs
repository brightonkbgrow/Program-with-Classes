using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("That is not a possible answer....");
        }
        Console.WriteLine($"Your Letter Grade is: {letter}");
        if (percent >= 70)
        {
            Console.WriteLine("Great Job! You Passed!");
        }
        else if (percent < 70)
        {
            Console.WriteLine("You've Failed. Try Again");
        }
        
    }

}