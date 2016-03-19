using System;
using System.Linq;

namespace CW_CSharp_IQ_Test
{
    class Program
    {
        public static int Test(string numbers)
        {
            int oddCount = 0;
            int oddTemp = 0;
            int evenCount = 0;
            int evenTemp = 0;

            int[] c = numbers.Split(' ').Select(str => int.Parse(str)).ToArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] % 2 == 0)
                {
                    evenCount++;
                    evenTemp = i + 1;
                }
                else
                {
                    oddCount++;
                    oddTemp = i + 1;
                }
            }
            return evenCount >= oddCount ? oddTemp : evenTemp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.Test("1 3 5 9 7 14 7 5 7 5"));
            Console.ReadKey();
        }
    }
}
