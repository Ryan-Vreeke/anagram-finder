using System;
using System.Text;

namespace test
{
    class radix
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            foreach (char c in input)
            {
                System.Console.WriteLine((int)c);
            }
        }
    }
}