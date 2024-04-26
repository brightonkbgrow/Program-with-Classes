using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userdigit = -1;
        
        while (userdigit != 0)
        {
            Console.WriteLine("Input numbers, enter 0 to stop.");
            string userinput = Console.ReadLine();
            userdigit = int.Parse(userinput);

            if (userdigit != 0)
            {
                numbers.Add(userdigit);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

        int average = sum / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Max: {max}");
    }
}
