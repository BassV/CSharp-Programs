using System;

namespace CW_CSharp_Build_a_pile_of_Cubes__6_kyu_
{
    class Program
    {
        public static long findNb(long m)
        {
            int n = 1;

            while (m > 0)
            {
                m -= (long)Math.Pow(n, 3);
                n++;
            }
            if (m != 0)
                return -1;

            return n - 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.findNb(24723578342962));

            Console.ReadKey();
        }
    }
}
