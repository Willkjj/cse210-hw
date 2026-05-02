using System;

class Program
{
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);

        return number;
    }
    static int promptUserBirthName()
    {
        Console.Write("Please enter your birth date: ");

        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);

        return number;
    }

    static int squareNumber(int n1)
    {
        return n1 * n1;
    }

    static void displayResult(string user, int number, int date)
    {
        int currentDate = DateTime.Now.Year;

        Console.WriteLine($"{user}, the square of your number is {number}");
        Console.WriteLine($"{user}, you will turn {currentDate - date} this year");


    }
    
    static void Main(string[] args)
    {
        displayWelcome();
        string user = promptUserName();
        int number = promptUserNumber();
        int date = promptUserBirthName();
        int squaredNumber = squareNumber(number);
        displayResult(user, squaredNumber, date);


    }
}