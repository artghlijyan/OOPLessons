﻿using System.Collections;

namespace OOPLessons.BaseModels
{
    public class Person
    {
        private protected string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name - {Name}, Age - {Age}";
        }

        public void Method()
        {
            System.Console.Write($"Name - {Name}, Age - {Age}");
        }
    }
}
