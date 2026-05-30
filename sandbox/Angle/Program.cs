class Program
{
    public static void Main()
    {
        Console.WriteLine("Wello Hurld!");

        Angle myAngle = new Angle();
        myAngle.SetRadians(10);

        Console.WriteLine(myAngle.GetRadians());

        Angle newAngle = new Angle(200.2);
        Console.WriteLine(myAngle.GetRadians());

    }
}