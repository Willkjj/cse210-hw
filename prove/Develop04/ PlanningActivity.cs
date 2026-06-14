class PlanningActivity : BaseActivity
{
    public PlanningActivity() : base ("Planning", "This activity will help you remember what you need to do. Write down your plans for the day ahead, either in the morning or just before you sleep, and review them when convenient.")
    {

    }

    public void RunActivity()
    {
        StartActivity();

        Console.Clear();
        RunCountdown("Get Ready...",3);
        DisplaySpinner(1);

        Console.WriteLine("Write down as many plans as you want:");
        
        startTime();
        while (CheckTime())
        {
            WriteToFile(Console.ReadLine());

        }

        DisplayEnding();

    }

    public void WriteToFile(string response)
    {
        DateTime now = DateTime.Now;
        using (StreamWriter outputFile = new StreamWriter("Plans", append: true))
        {
            outputFile.WriteLine($"{now.Date} - {now.Hour}:{response}");
        }
    }
}