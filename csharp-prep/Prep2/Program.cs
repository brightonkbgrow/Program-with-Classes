using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        if (percent >= 90)
        {
            Console.WriteLine("Your Grade is an A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Your Grade is an B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Your Grade is an C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Your Grade is an D");
        }
        else if (percent < 60)
        {
            Console.WriteLine("You got an F");
        }
        else
        {
            Console.WriteLine("That is not a possible answer....");
        }
    }

}