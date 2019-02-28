using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalPath = @"C:\Users\LENOVO\Desktop\PP2\Lab2\task4.txt";
            string copyPath = @"C:\Users\LENOVO\Desktop\PP2\Lab2\Task 4\task4.txt";
            FileStream fs = new FileStream(originalPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            sr.Write("end of second lab works");
            sr.Close();
            fs.Close();

            File.Copy(originalPath, copyPath);
            File.Delete(originalPath);

        }
    }
}
