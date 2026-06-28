class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        int y = x;
        x ++;
        Console.WriteLine(x);
        Console.WriteLine(y);

        int[] data = [1,2,3,4];
        int[] data2 = data;
        
        data[0] += 100;
        Console.WriteLine(data2[0]);



    }
}