using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcalcula
{
    internal class Exam2of2
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s1 = new Student(10, "tanuja", "xyz");
            s1.display();
        }
    }
    public class Student
    {
        int rollno;
        string name, address;

        public Student()
        {
            Console.WriteLine(" ");
        }
        public Student(int rollno, string name, string address)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("RollNo: "+rollno+"Name: "+name+"Address: "+address);
        }
    }
}
