using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создвем переменное 
            int i, j;//переменные
            int[,] a = new int[n, n];// создаем двухмерный массив


            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j || i > j) // если ай и джей совпадает указанному условию то в консоле выводится решение
                    {
                        Console.Write("[*]" + ' ');//вывод на экран
                    }

                }
                Console.WriteLine();//след запись на новой строке
            }
        }
    }
}
