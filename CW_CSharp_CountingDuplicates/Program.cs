using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_Tests1
{
    class Program
    {
        public static int DuplicateCount(string str)
        {
            str = str.ToUpper();
            int count = 0; // The number of characters that have duplicates

            List<char> list = new List<char>();

            char[] charArray = str.ToCharArray(); // Convert all the characters of "str" into char and store in the array "charArray"
            /*
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (Char.IsUpper(charArray[i]))
                    return 0;
            }
            */
            Array.Sort(charArray);

            for (int i = 0; i < str.Length - 1; i++) // Loop through all the characters of the "str"
            {
                if (list.Contains(charArray[i])) // If the character already exists in the list
                {
                    int rep = str.Split(charArray[i]).Length - 1;
                    i += rep - 2;

                    count++;
                    //list.Remove(charArray[i]);

                }

                else
                    list.Add(charArray[i]); // Add the character into out list

            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aabBcde"));

            Console.ReadKey();
        }

    }
}
