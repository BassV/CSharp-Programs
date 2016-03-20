using System;
using System.Collections.Generic;

namespace CW_CSharp_Triple_trouble
{
    class Program
    {
        public static int TripleDouble(long num1, long num2)
        {
            long checker = -1;
            long final = -1;

            // Store the digits of num1 in elems1
            List<long> elems1 = new List<long>();
            while (num1 > 0)
            {
                elems1.Add(num1 % 10);
                num1 /= 10;
            }
            // Check if there exists 3 equal numbers following each other in num1 = checker
            for (int i = 0; i < elems1.Count - 2; i++)
            {
                if (elems1[i] == elems1[i + 1])
                    if (elems1[i + 1] == elems1[i + 2])
                        checker = elems1[i];
            }

            // Store the digits of num2 in elems2
            List<long> elems2 = new List<long>();
            while (num2 > 0)
            {
                elems2.Add(num2 % 10);
                num2 /= 10;
            }
            // Check if "checker" occurs in elems2 straight twice
            for (int i = 0; i < elems2.Count - 1; i++)
            {
                if (elems2[i] == checker)
                    if (elems2[i] == elems2[i + 1])
                        final = checker;
            }

            if (checker == -1 || final == -1)
                return 0;

            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.TripleDouble(6463668882, 23488));
            Console.ReadKey();
        }
    }
}
