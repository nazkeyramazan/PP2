using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //ввод числа
            int i;//переменная
            int[] a = new int[n]; //создвние массива

            string[] nums = Console.ReadLine().Split(new char[] { ' ' });// ввод элементов массива
            // сплит разделяет ввеенные числа
            for (i = 0; i < a.Length; i++)
                a[i] = int.Parse(nums[i]);

            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");// вывод на консоль решение задачи
            }
        }
    }
}
