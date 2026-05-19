using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 30; i++)
        {
            Fraction fraction = new Fraction();
            Random rand = new Random();

            fraction.SetTop(rand.Next(1,10));
            fraction.SetBottom(rand.Next(1,10));

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }


        

    }
}