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
            int i;
            int[] a = new int[n]; //создвние массива

            string[] nums = Console.ReadLine().Split(new char[] { ' ' });

            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i]); // ввод элементов массива
            }

            /*for (i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                new_array[2 * i] = doub[2 * i + 1] = a[i]; 
            }*/

            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");// вывод на консоль решение задачи
            }
        }
    }
}
