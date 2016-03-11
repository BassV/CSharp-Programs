using System;

namespace CW_CSharp_Complete_The_Pattern_No1
{ 
    class Program
    {
        public string Pattern(int n)
        {
            string pattern = "";
            if (n < 1)
                return "";

            for (int i = 1; i <= n; i++)
            {  
                for (int j = 1; j <= i; j++)
                {
                    string insertion = i.ToString();
                    pattern = pattern.Insert(pattern.Length, insertion);
                    
                }
                if (i < n) 
                    pattern = pattern.Insert(pattern.Length, "\n");
            }

            return pattern;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Pattern(8));
            Console.ReadKey();
        }
    }
}
