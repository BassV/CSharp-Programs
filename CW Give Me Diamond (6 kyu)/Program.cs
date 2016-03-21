using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_CSharp_Give_Me_Diamond
{
    class Program
    {
        public static string print(int n)
        {
            StringBuilder final = new StringBuilder();

            if (n % 2 == 0 || n < 0)
                return null;

            for (int i = 0; i < n / 2; i++)
            {
                final.Append(' ', (n - 2 * i) / 2);
                final.Append('*', 2 * i + 1);
                final.Append("\n");
            }

            final.Append('*', n);
            final.Append("\n");

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                final.Append(' ', (n - 2 * i) / 2);
                final.Append('*', 2 * i + 1);
                final.Append("\n");
            }

            return final.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.print(9));
            Console.ReadKey();
        }
    }
}
