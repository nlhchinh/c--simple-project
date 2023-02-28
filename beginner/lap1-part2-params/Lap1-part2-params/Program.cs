class Program
{
    static double CalculateAverage(params double[] values)
    {
        double sum = 0;
        for (int i = 0; i < values.Length; i++)
            sum += values[i];

        return (sum / values.Length);
    }

    static void Main(string[] args)
    {
        double average;
        average = CalculateAverage(4.0, 3.2, 5.7);
        Console.WriteLine("Average of 4.0, 3.2, 5.7 is {0}", average);

        double[] data = { 4.0, 3.2, 5.7 };
        average = CalculateAverage(data);
        Console.WriteLine("Average of data is: {0}", average);
        Console.ReadLine();
    }
}
