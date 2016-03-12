using System;

namespace CW_CSharp_Dubstep
{
    class Program
    {
        public static string SongDecoder(string input)
        {
            input = input.Replace("WUB", " "); // Change WUB to a space
            input = input.Trim(); // Trim(Delete) the spaces from the Start and the End of the string

            for (int i = 0; i < input.Length - 1; i++) // Loop through all the elements of the string
            {
                if (input.Substring(i, 1) == input.Substring(i + 1, 1)) // If two consecutive elements of the array are equal
                {                  
                    if (input.Substring(i, 1) == " ") // If the element is a space
                    {
                        input = input.Replace("  ", " "); // Change 2 spaces with 1
                        // By changing 2 spaces with one, the length of the string got smaller
                        // Thus, we will miss an item if we dont not make i's length smaller too
                        i--; 

                    }
                }
            }
            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("WUBWUBIWUBWUBAMWUBVWUB"));
            Console.ReadKey();
        }
    }
}
