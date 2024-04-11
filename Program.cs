using System;
using System.Linq;

public static class Statistics
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        else
        {
            return numbers.Average();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = Statistics.CalculateAverage(numbers);
        Console.WriteLine("Średnia wynosi: " + average);
    }
}