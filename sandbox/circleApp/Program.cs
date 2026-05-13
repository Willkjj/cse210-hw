class Program
{
    public static void Main(string[] args)
    {
        Cirlce myCircle = new Cirlce();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        Cirlce myCircle2 = new Cirlce();
        myCircle2._radius = 30;
        Console.WriteLine(myCircle2.GetArea());

        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = new Cirlce();
        myCylinder._height = 30;
        Console.WriteLine(myCylinder.GetCylinderVolume());
    }   
}