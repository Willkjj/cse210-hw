class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endtime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endtime = DateTime.Now;
    }

    public void StartActivity()
    {
        //display greeting, display name, get duration
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How many seconds would you like to spend on this activity? ");

        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountdown(string message, int duration)
    {
        Console.CursorVisible = false;

        Console.Write($"{message}");
        while (duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();

        Console.CursorVisible = true;
    }

    public void DisplaySpinner(int time)
    {
        string animationString = "-\\|/";
        Console.CursorVisible = false;

        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[i++ %animationString.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
        Console.CursorVisible = true;

    }

    public void startTime()
    {
        _endtime = DateTime.Now;
        _endtime = _endtime.AddSeconds(_duration);

    }

    public bool CheckTime()
    {
        if (DateTime.Now >= _endtime)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

        public void DisplayEnding()
    {
        Console.Clear();
        Console.Write($"Thank you for participating in the {_name} activity! You particpated for {_duration} seconds.");
        Console.Write("  ");
        DisplaySpinner(5);
    }

    public string GetPrompt(string[] list)
    {
        Random random = new Random();
        return list[random.Next(0,list.Length)];
    }
}