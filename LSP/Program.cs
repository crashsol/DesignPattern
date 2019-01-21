using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]
            {
                5,6,7,8,9,11,22,1,23,44
            };
            SumCalculator sum = new SumCalculator(numbers);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            Console.ReadLine();
        }
    }
}
