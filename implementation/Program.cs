using System;
using System.Linq;

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
            if(a == b) return 2 * a;
            if(a > b) return SumAll(b, a);

            return Enumerable
                .Range(a, b - a + 1)
                .Sum();
        }
    }
}
