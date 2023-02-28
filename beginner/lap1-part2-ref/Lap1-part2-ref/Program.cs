class Program
{
    public static void SwapStrings(ref string s1, ref string s2)
    {
        string tempStr = s1;
        s1 = s2;
        s2 = tempStr;
    }

    static void Main(string[] args)
    {
        string s = "First string";
        string s2 = "My other string";
        Console.WriteLine("Before: {0}, {1} ", s, s2);

        SwapStrings(ref s, ref s2);

        Console.WriteLine("After: {0}, {1} ", s, s2);

        Console.WriteLine();
    }
}
