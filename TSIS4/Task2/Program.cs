using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int point;
        public string Letter;
        public Mark(int n)
        {
            point = n;
            Letter = getLetter(point);
        }

        public static string getLetter(int point)//method to get letter of point
        {
            string bukva = null;
            if (point <= 100 && point >= 95) {bukva = "A"; }
            else  if (point <= 94 && point >= 90) { bukva = "A-"; }
            else  if (point <= 89 && point >= 85) { bukva = "B+"; }
            else  if (point <= 84 && point >= 80) { bukva = "B"; }
            else  if (point <= 79 && point >= 75) { bukva = "B-"; }
            else  if (point <= 74 && point >= 70) { bukva = "C+"; }
            else if (point <= 69 && point >= 65) { bukva = "C"; }
            else if (point <= 64 && point >= 60) { bukva = "C-"; }
            else  if (point <= 59 && point >= 55) { bukva = "D+"; }
            else if (point <= 54 && point >= 50) { bukva = "D"; }
            else if (point <= 49 && point >= 0) { bukva = "F"; }
            else if (point < 0 || point > 100) { bukva = "Please enter number in range 0 to 100"; }
            return bukva;
        }
        public Mark()//constructor with less parameters
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Serialization();//call function
            Deserialization();//call function
        }

        private static void Deserialization()
        {
            FileStream fs1 = new FileStream("mark.txt" , FileMode.Open , FileAccess.Read);// show what to do with ...txt file
            XmlSerializer xs1 = new XmlSerializer(typeof(List<Mark>));
            List<Mark> mark = xs1.Deserialize(fs1) as List<Mark>;//deserialize
            fs1.Close();//close
        }

        private static void Serialization()
        {
            Mark mark = new Mark();
            List<Mark> markList = new List<Mark>();
            Mark first = new Mark(65);//point
            Mark second = new Mark(101);//point
            Mark third = new Mark(85);//point

            markList.Add(first);//add to List point
            markList.Add(second);//add to List point
            markList.Add(third);//add to List point

            FileStream fs = new FileStream("mark.txt" , FileMode.OpenOrCreate , FileAccess.Write);// show what to do with ...txt file
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));//choose what to serialize
            xs.Serialize(fs, markList);//serialize the list of mark to file "mark.txt"
            fs.Close();//close
        }
    }
}
