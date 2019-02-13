using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_3
{
    class Program
    {
        public static void f(DirectoryInfo dir , int lvl)
        {
            
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                for (int i = 0; i < lvl; i++)
                Console.Write("   ");//отступ
                Console.WriteLine(d.Name); // консоль выводит имя папки
                f(d, lvl + 1); // удваивание отступа
            }
            foreach (FileInfo f in dir.GetFiles())
            {
                for (int i = 0; i < lvl; i++)
                Console.Write("   ");//отступ 
                Console.WriteLine(f.Name);//консоль выводит имя файла
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/LENOVO/Desktop/PP2/Lab2");//указывает путь к папке
            f(dir, 0);//вызывает ранее написанную функцию
            Console.ReadKey();// пока не нажмете любую клаву
          
        }
    }
}






