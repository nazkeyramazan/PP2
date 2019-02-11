using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{ class Student { 

    public string name;
    public string ID;
    public int year;

    public Student(string name, string ID)
    {
        this.name = name;
        this.ID = ID;
    }
    public Student(string name, string ID, int year)
    {
        this.name = name;
        this.ID = ID;
        this.year = year;
    }


    public void increment()
        {

        }

    public string getName()
        {
            return this.name;
        }
    public void PrintInfo()
    {
        Console.WriteLine(name + " " + ID + " " + year);
        year++;
        Console.WriteLine(name + " " + ID + " " + year);

    }
}

    class Program
    {
        
        static void Main(string[] args)
        {
            Student s = new Student("Ramazan" , "18BD143343" , 1);
            s.PrintInfo();

        }
    }
}
