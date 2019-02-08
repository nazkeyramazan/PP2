using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // ввод значения n
            int i, j, p, cnt = 0; // переменные
            int[] arr = new int[n]; // создание массива

            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });// ввод элементов в массив
            // сплит разделяет введенные числа
            for (i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(nums[i]);

            for (i = 0; i < arr.Length; i++)
            {
                p = 1;
                if (arr[i] == 1)//идентичный случай
                    p = 0;
                if (arr[i] == 2)//идентичный случай
                    p = 1;
                for (j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0) // если общее число делителя чисел больше двух то она не прайм намбер
                    {
                        p = 0;//если число делится другие числа то переход след элемент массива 
                        break;
                    }       
                }
                if (p == 1)
                    cnt++; // если находится прайм намбер то каунтер доюавляетсz              
            }
            Console.WriteLine(cnt);
            for (i = 0; i < arr.Length; i++)
            {
                p = 1;
                if (arr[i] == 1)
                    p = 0;
                if (arr[i] == 2)
                    p = 1;
                for (j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0) // если общее число делителя чисел больше двух то она не прайм намбер
                    {
                        p = 0;
                        break;
                    }
                }
                if (p ==1)
                Console.Write(arr[i] + " ");
            }
            
        }
    }
}
