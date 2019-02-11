using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static string reverse(string p)
        {
            char[] s = p.ToCharArray();
            Array.Reverse(s);
            return new string(s);
        }
        static void Main(string[] args)
        {
            string p = System.IO.File.ReadAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/palindrome.txt");
            if (p.Equals(reverse (p)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
