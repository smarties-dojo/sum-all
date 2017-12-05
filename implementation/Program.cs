using System;

namespace SumAllNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int SumAll(int a, int b)
        {
            int lowerBound = Math.Min(a, b);
            int upperBound = Math.Max(a, b);

            int sum = 0;

            for(int i = lowerBound; i <= upperBound; i++) {
                sum += i;
            }

            return sum;
        }
    }
}
