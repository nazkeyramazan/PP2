using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = System.IO.File.ReadAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/input.txt");

            //char[] charsToTrim = { '*', ' ', '\'' };
            //string result = line.Trim(charsToTrim);


            string[] p = line.Split(new char[] { ' ', ','});
            string prime = "";
            for (int i = 0; i < p.Length; i++)
            {
                int cnt = 0;
                Console.Write(p[i]+ " ");
                int b = Convert.ToInt32(p[i]);

                

                for (int j = 1; j < b; j++)

                {
                    if (b % j == 0)
                        cnt++;
                }
                if (b == 1)
                {
                    continue;
                }
                if (cnt <= 1)
                {
                    prime += b;
                    prime += " ";
                }
            }
            System.IO.File.WriteAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/output.txt", prime);
        }
    }
}
