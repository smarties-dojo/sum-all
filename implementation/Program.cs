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
            if(a > b) return SumAll(b, a);

            int sum = 0;

            for(int i = a; i <= b; i++) {
                sum += i;
            }

            return sum;
        }
    }
}
