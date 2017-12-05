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

            if(a == b) return a;

            return a + SumAll(a+1, b);
        }
    }
}
