class Program
{
    public static void Add(int x, int y, out int ans)
    {
        ans = x + y;
    }

    static void Main(string[] args)
    {
        int ans;
        Add(90, 90, out ans);
        Console.WriteLine("90 + 90 = {0}", ans);
        Console.ReadLine();
    }
}