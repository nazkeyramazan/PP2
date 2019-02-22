using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
      public  class Complex//new class
      {
        public int a;//real part of complex number
        public int b;//imaginary part of complex number
        public Complex() // new constructor with less parameters
        {
            
        }
        
        public void PrintInfo()
        {
            Console.WriteLine("Complex number :" + a + " + " + ( b + "i"));//comlex number
        }
      }
    class Program
    {
        static void Main(string[] args)
        {
            Serialization();// call function
            Deserialization(); // call function
        }

        private static void Deserialization()//function
        {
            FileStream fs = new FileStream("complex1.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Complex));
            Complex s = xml.Deserialize(fs) as Complex;//deserialization of first complex number
           // s.PrintInfo();
            fs.Close();
            FileStream fs1 = new FileStream("complex2.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml1 = new XmlSerializer(typeof(Complex));
            Complex t = xml1.Deserialize(fs1) as Complex;//deserialization of second comlplex number
           // t.PrintInfo();
            fs1.Close();
        } 

        public static void Serialization()//function
        {
            Complex s = new Complex();
            Console.WriteLine("Please write a real part of first complex number:");//console info
            s.a = int.Parse(Console.ReadLine());//input parameters
            Console.WriteLine("Please write a imaginary part of first complex number:");//console info
            s.b = int.Parse(Console.ReadLine());//input parameters


            Complex t = new Complex();
            Console.WriteLine("Please write a real part of second complex number:");//console info
            t.a = int.Parse(Console.ReadLine());//input parameters
            Console.WriteLine("Please write a imaginary part of second complex number:");//console info
            t.b = int.Parse(Console.ReadLine());//input parameters

            s.PrintInfo();
            t.PrintInfo();

            FileStream fs = new FileStream("complex1.txt" , FileMode.Create , FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Complex));
            xml.Serialize(fs, s);//serialization of first complex number
            fs.Close();
            FileStream fs1 = new FileStream("complex2.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xml1 = new XmlSerializer(typeof(Complex));
            xml1.Serialize(fs1, t);//serialization of second complex number
            fs1.Close();

        }
    }
}
