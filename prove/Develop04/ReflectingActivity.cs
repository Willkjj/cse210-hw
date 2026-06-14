class ReflectingActivity : BaseActivity
{
    private string[] _startingPrompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };

    public ReflectingActivity() : base ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {


    }

    public void RunActivity()
    {
        StartActivity();

        Console.Clear();
        RunCountdown("Get Ready...",3);
        DisplaySpinner(1);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {GetPrompt(_startingPrompts)} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to the experience.");
        RunCountdown("You may begin in:", 5);
        Console.Clear();
        
        startTime();
        while (CheckTime())
        {
            Console.Write(GetPrompt(_questions));
            Console.Write("  ");
            DisplaySpinner(5);
            Console.Write("\b ");

            Console.WriteLine();

        }

        DisplayEnding();

    }


}