using System;
using System.Reflection.Metadata.Ecma335;

class Program
{

    static void displayGreeting()
    {
        Console.WriteLine("heya");
    }
    static double addNumbers(int n1, int n2, double n3)
    {
        double total = n1 + n2 + n3; 
        return total;
    }
    static void Main(string[] args)
    {
        displayGreeting();
        double total = addNumbers(2,10,140);
        Console.WriteLine(total);

        //comment.
        // Console.WriteLine("Hello Sandbox World!");
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // List<int> data = new List<int>();
        // data.Add(1);
    }
}