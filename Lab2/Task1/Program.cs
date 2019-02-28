using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        private static string reverse(string p)
        {
            char[] s = p.ToCharArray();// массив чаров
            Array.Reverse(s);// переварачивает массив
            return new string(s);//возвращает новый стринг
        }
        static void Main(string[] args)
        {
            
            string p = File.ReadAllText(@"C:/Users/LENOVO/Desktop/PP2/Lab2/palindrome.txt");//читает текст и передает данные к стрингу
            if (p.Equals(reverse (p))) // сравнивает текст и обратный текст
            {
                Console.WriteLine("Yes"); // одинаковы 
            }
            else
            {
                Console.WriteLine("No"); // нет
            }
        }
    }
}
