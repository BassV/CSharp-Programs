using System;
using System.Collections.Generic;

namespace CW_CSharp_Multiples_of_3_and_5__6_kyu_
{
    class Program
    {     
        public static int Solution(int value)
        {
            List<int> l = new List<int>();
            int sum = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    l.Add(i);
            }

            foreach (int j in l)
                sum += j;

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.Solution(10));
            Console.ReadKey();
        }
    }
}