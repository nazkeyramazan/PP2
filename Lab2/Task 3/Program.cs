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

        public static void p(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("____");
        }
        public static void f(DirectoryInfo dir, int level)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                p(level);
                Console.WriteLine(d.Name);
                f(d, level + 1);
            }
            foreach (FileInfo f in dir.GetFiles())
            {
                p(level);
                Console.WriteLine(f.Name);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/LENOVO/Desktop/PP2/Lab2");
            f(dir, 0);
            Console.ReadKey();
        }
    }
}
