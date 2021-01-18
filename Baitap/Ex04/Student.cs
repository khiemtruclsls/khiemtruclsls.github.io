using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Student
    {
        private string name {get;set;}
        private string roll{get;set;}
       
        public int age { get; set; }
        private string address { get; set; }

        public Student()
        {
        }

        public Student(string name, string roll, int age, string address)
        {
            this.name = name;
            this.roll = roll;
            this.age = age;
            this.address = address;
        }
        public void Input()
        {
            Console.WriteLine("Please enter name student : ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter roll :  ");
            roll = Console.ReadLine();
            Console.WriteLine("Please enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter address : ");
            address = Console.ReadLine();
        }
        public void output() {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("RollNumber : " + roll);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Address : " + address);

        }
    }
}
