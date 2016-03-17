using System;

namespace CW_CSha_Playing_with_passphrases__6kyu_
{
    class Program
    {
        public static string playPass(string s, int n)
        {
            char[] c = s.ToLower().ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (Char.IsLetter(c[i]))
                {
                    c[i] = (char)(c[i] + n);

                    if (c[i] > 'z')
                        c[i] = (char)(c[i] - 26);

                    if (i % 2 == 0)
                        c[i] = char.ToUpper(c[i]);
                }
                else if (Char.IsNumber(c[i]))
                    c[i] = ('9' - c[i]).ToString()[0];
            }
            Array.Reverse(c);
            return new string(c); ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));
            // "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"
            Console.ReadKey();
        }
    }
}
