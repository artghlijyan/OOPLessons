using System;
using System.Collections;

namespace OOPLessons.BaseModels
{
    public abstract class Person : ICloneable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Walk()
        {
            System.Console.WriteLine("I am walking");
        }

        public virtual void Speak()
        {
            System.Console.WriteLine("I am speaking");
        }

        public override string ToString()
        {
            return $"Name - {Name}, Age - {Age}";
        }

        public abstract object Clone();
    }
}
