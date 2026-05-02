using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        int input = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter a number: ");

            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            
            if (input != 0)
            {
                numbers.Add(input);
                
            }

            
        } while (input != 0);

        int sum = 0;
        int i = 0;
        int highest = 0;
        int smallest = 0;

        foreach (int number in numbers)
        {
            i++;
            sum += number;

            if (number > highest)
            {
                highest = number;
            }

            if (number > 0)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

        }

        numbers.Sort();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum / i}");
        Console.WriteLine($"The highest number is {highest}");
        Console.WriteLine($"The smallest postive number is {smallest}");
        Console.WriteLine($"The sorted list is");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}