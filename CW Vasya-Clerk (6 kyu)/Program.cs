using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_CSharp_Vasya_Clerk__6_kyu_
{
    class Program
    {
        public static string Tickets(int[] peopleInLine)
        {
            int d25 = 0;
            int d50 = 0;

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                    d25++;

                if (peopleInLine[i] == 50)
                {

                    d50++;
                    d25--;

                    if (d25 < 0)
                        return "NO";
                }
                if (peopleInLine[i] == 100)
                {
                    while (peopleInLine[i] > 25)
                    {
                        if (d50 > 0 && peopleInLine[i] >= 75)
                        {
                            peopleInLine[i] -= 50;
                            d50--;
                        }
                        else
                        {
                            peopleInLine[i] -= 25;
                            d25--;
                        }
                    }
                    if (d25 < 0)
                        return "NO";
                }
            }
            return "YES";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.Tickets(new int[] { }));

            Console.ReadKey();
        }
    }
}
