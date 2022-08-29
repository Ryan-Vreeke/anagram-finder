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
            ArrayList list = new ArrayList();
            //Parsing input for the numbers
            string numbers = Console.ReadLine();
            int n = Convert.ToInt32(numbers.Split(' ')[0]);
            int k = Convert.ToInt32(numbers.Split(' ')[1]);
            int count = 0;

            for (int i = 0; i < n; i++)//first loop to gather input and place into dictionary and list O(n)
            {
                string input = StringSort(Console.ReadLine());
                if(dictionary.ContainsKey(input)){
                    dictionary[input] = dictionary[input] + 1;
                }else{
                    dictionary.Add(input, 0);
                }
            }

            foreach(string s in dictionary.Keys){
                if(dictionary[s] == 0){
                    count++;
                }
            }

            System.Console.WriteLine(count);
        }


        public static string StringSort(string input)
        {
            char[] array = input.ToCharArray();
            Array.Sort(array);
            return new string(array);
        }
    }
}