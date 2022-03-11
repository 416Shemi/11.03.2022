using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Teacher:Person
    {
        public Teacher()
        {

        }
        public int salary;
        public Teacher(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public Teacher(string name, string surname): this (name)
        {
            this.surname = surname;
            Console.WriteLine(surname);
        }
        public Teacher(string name,string surname,int age):this(surname)
        {
            this.age = age;
            Console.WriteLine(age);
        }
    }
}
