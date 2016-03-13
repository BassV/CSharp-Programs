using System;
using System.Collections.Generic;

namespace CW_CSharp_Sum_Consecutives__6_kyu_
{
    class Program
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            int sum = 0;
            int count = 1;
            List<int> newList = new List<int>();

            // Loop through all the elements of the list 
            for (int i = 0; i < s.Count - 1; i++)
            {
                // If two consecutive elements are equal, count them and get their sum
                if (s[i] == s[i + 1])
                {
                    count++;
                    sum = count * s[i];
                }
                // If they are not equal, push them to the "newList" list 
                else if (s[i] != s[i + 1])
                {
                    // If the elements were equal, push their sum into the new list
                    if (sum != 0)
                        newList.Add(sum);

                    // If the elements were not equal, push the  i'th element
                    if (sum == 0)
                        newList.Add(s[i]);

                    // This code will add the last element of the list to the new list 
                    if (i == s.Count - 2)
                        newList.Add(s[s.Count - 1]);

                    sum = 0; 
                    count = 1;
                }      
            }

            return newList;
        }

        static void Main(string[] args)
        {
            // Test case 1
            List<int> before1 = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
            List<int> after1 = new List<int> { 1, 12, 0, 4, 6, 1 };

            // Test case 2
            List<int> before2 = new List<int> { -5, -5, 7, 7, 12, 0 };
            List<int> after2 = new List<int> { -10, 14, 12, 0 };

            Console.WriteLine("Test 1 is " + UnorderedEqual(after1, Program.SumConsecutives(before1))); // If True, the test works correctly
            Console.WriteLine("Test 2 is " + UnorderedEqual(after2, Program.SumConsecutives(before2))); 
            Console.ReadKey();
        }

        // Reference: UnorderedEqual generic method was taken from http://www.dotnetperls.com/list-equals
        // This method is used for checking the equality of the lists
        // Note that this method only compares the number of occurrences of the elements of the lists
        // Thus, it will not check whether the positions of the elements are the same or not
        static bool UnorderedEqual<T>(ICollection<T> a, ICollection<T> b)
        {
            // Require that the counts are equal
            if (a.Count != b.Count)
                return false;

            // Initialize new Dictionary of the type
            Dictionary<T, int> d = new Dictionary<T, int>();

            // Add each key's frequency from collection A to the Dictionary
            foreach (T item in a)
            {
                int c;
                if (d.TryGetValue(item, out c))
                    d[item] = c + 1;
                else
                    d.Add(item, 1);
            }

            // Add each key's frequency from collection B to the Dictionary
            // Return early if we detect a mismatch
            foreach (T item in b)
            {
                int c;
                if (d.TryGetValue(item, out c))
                {
                    if (c == 0)
                        return false;
                    else
                        d[item] = c - 1;
                }
                else           
                    return false; // Not in dictionary
            }

            // Verify that all frequencies are zero
            foreach (int v in d.Values)
                if (v != 0)
                    return false;
       
            return true; // We know the collections are equal
        }
    }
}
