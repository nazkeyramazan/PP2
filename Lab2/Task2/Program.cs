using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = File.ReadAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/input.txt"); //  читает текст
            string[] p = line.Split(new char[] { ' ', ','}); // разделяет по указанным значкам
            string prime = ""; // новая переменная
            for (int i = 0; i < p.Length; i++)//пробегается по массиву
            {
                int cnt = 0; // переменная
                Console.Write(p[i]+ " ");
                int b = Convert.ToInt32(p[i]);//переводит в числу
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
            File.WriteAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/output.txt", prime);
        }
    }
}
