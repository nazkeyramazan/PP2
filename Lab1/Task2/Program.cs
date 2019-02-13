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

    public Student(string name, string ID, int year) //создание нового класса под имененм студент
    {
        this.name = name; //данные класса студент 
        this.ID = ID; //
        this.year = year;//
    }


    public void increment()
        {
            year++;//увеличивает год на единицу
        }

    public void getName()
        {
            Console.WriteLine("Имя " + name);//выводит на консоль имя студента
            return ;
        }
        public void getID()
        {
            Console.WriteLine("ID " + ID);//выводит на консоль АЙДИ студента
            return;
        }
        public void getYear()
        {
            Console.WriteLine("Год обучения " + year);//выводит на консоль год обучения студента
            return;
        }
        
}

    class Program
    {
        
        static void Main(string[] args)
        {
            Student s = new Student("Ramazan" , "18BD143343" , 1);//присвоение значения для данного класса
            s.getName(); // использование ранее написанного кода 
            s.getID();//
            s.getYear();//
            s.increment();//
            s.getName();//
            s.getID();//
            s.getYear();//
        }
    }
}
