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
    
    public static int CalculateMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        return numbers.Max();
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = Statistics.CalculateAverage(numbers);
        Console.WriteLine("Średnia wynosi: " + average);

        double max = Statistics.CalculateMaxValue(numbers);
        Console.WriteLine("Maksymalna wartośc wynosi: " + max);
    }
}