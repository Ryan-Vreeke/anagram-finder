using System;
using System.Collections;
using System.Collections.Generic;

namespace algorithms
{
    class Ps0
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //Parsing input for the numbers
            string numbers = Console.ReadLine();
            int n = Convert.ToInt32(numbers.Split(' ')[0]);
            int k = Convert.ToInt32(numbers.Split(' ')[1]);

            for (int i = 0; i < n; i++)//first loop to gather input and place into dictionary and list O(n)
            {
                string input = Console.ReadLine();
                dictionary.Add(input, 0);//time complexity to insert into a dictionary is O(1)
            }

            // running algorithm
            int count = 0;
            foreach (string w in words)
            {
                bool anagram = false;

                if (dictionary[w] == 0)
                {
                    foreach (string p in GetPermutations(w))
                    { //get permuations of a word w and loop through them. Time complexity is O(k!)
                        if (dictionary.ContainsKey(p) && p != w)
                        {
                            anagram = true;
                            dictionary[p] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    anagram = true;
                }


                if (!anagram)
                {
                    count++;
                }

            }

            System.Console.WriteLine(count);
        }
    }
}