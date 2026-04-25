using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse(valueFromUser);

        bool plus = false;

        if (grade % 10 < 5)
        {
            plus = false;
        } else
        {
            plus = true;
        }

        if (grade >= 90)
        {
            if (plus == false)
            {
                Console.WriteLine("Your grade is an A-");
            } else
            {
                Console.WriteLine("Your grade is an A");
            }
        } else if (grade >= 80)
        {
            if (plus == false)
            {
                Console.WriteLine("Your grade is an B-");
            } else
            {
                Console.WriteLine("Your grade is an B+");
            }
        } else if (grade >= 70)
        {
            if (plus == false)
            {
                Console.WriteLine("Your grade is an C-");
            } else
            {
                Console.WriteLine("Your grade is an C+");
            }
        } else if (grade >= 60)
        {
            if (plus == false)
            {
                Console.WriteLine("Your grade is an D-");
            } else
            {
                Console.WriteLine("Your grade is an D+");
            }
        } else
        {
            Console.WriteLine("Your grade is an F");
        }
    }
}