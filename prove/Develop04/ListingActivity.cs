class ListingActivity : BaseActivity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

        public ListingActivity() : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void RunActivity()
    {
        StartActivity();

        Console.Clear();
        RunCountdown("Get Ready...",3);
        DisplaySpinner(1);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {GetPrompt(_prompts)} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        RunCountdown("You may begin in:", 5);
        
        startTime();
        while (CheckTime())
        {
            Console.ReadLine();


        }

        DisplayEnding();

    }

}