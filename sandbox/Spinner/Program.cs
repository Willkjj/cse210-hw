class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        int sleepTime = 250;

        string animationString = "-\\|/";
        
        // for (int i =0; i < 20; i++)
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(10);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[i++ %animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }


        // Counter?
        // I hardly know her!
        int count = 15;
        DateTime now2 = DateTime.Now;
        DateTime endTime2 = now2.AddSeconds(count);

        while (DateTime.Now < endTime2)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.CursorVisible = true;

    }
}