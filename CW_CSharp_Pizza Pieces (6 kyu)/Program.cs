using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_CSharp_Pizza_Pieces__6_kyu_
{
    class Program
    {
        public static int maxPizza(int cut)
        {
            int pieces = 1;

            if (cut < 0)
                return -1;

            for (int i = 0; i <= cut; i++)
                pieces += i;

            return pieces;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.maxPizza(3));
            Console.ReadKey();
        }
    }
}
