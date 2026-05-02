using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,100);

        int i = 0;
        int guess = 0;

        do
        {
            i++;

            Console.Write("What is the magic number? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            
            if (guess < num)
            {
                Console.WriteLine("Higher!");

            } else if (guess > num)
            {
                Console.WriteLine("Lower!");

            } else if (guess == num)
            {
                Console.WriteLine($"Congrats! You guessed it in only {i} gueses!");
            }

            
        } while (guess != num); 
    }
}