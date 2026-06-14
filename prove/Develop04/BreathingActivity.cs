class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base ("Breathing", "This activity will help you practice calm breathing")
    {

    }

    public void RunActivity()
    {
        StartActivity();

        Console.Clear();
        RunCountdown("Get Ready...",3);
        DisplaySpinner(1);
        
        startTime();
        while (CheckTime())
        {
            RunCountdown("Breathe In...", 4);
            RunCountdown("Breathe Out...", 6); 
        }
        
        DisplayEnding();
    }



}