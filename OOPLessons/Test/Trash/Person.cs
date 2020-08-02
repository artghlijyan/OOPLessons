using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.Test.Trash
{
    class Person
    {
        public string name;
        public int age;

        public Person() : this("UnKnown")
        {

        }

        public Person(string name1) : this(name1, 18)
        {

        }

        public Person(string name1, int age1)
        {
            this.name = name1;
            this.age = age1;
        }

        private void GetInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

        public override string ToString()
        {
            this.GetInfo();
            return base.ToString();
        }
    }
}
