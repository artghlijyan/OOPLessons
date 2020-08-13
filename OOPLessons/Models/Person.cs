using System;

namespace OOPLessons.Models
{
    public class Person
    {
        private int _age;

        //public const string Description = "This is Person Class";

        public static readonly string Description;

        public static int Counter { get; private set; }

        public int Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                if(value < 18)
                {
                    throw new Exception("Person must be adult");
                }

                this._age = value;
            }
        }

        public string Name { get; set; }

        static Person()
        {
            Description = "This is Person Class";
            Counter = default;
        }

        public Person() 
        {
            Counter++;
        }

        public Person(string name, int age) : this()
        {
            this.Name = name;
            this.Age = age;
        }

        private string Info()
        {
            return string.Format($"Name: {Name}  Age: {Age}");
        }

        public override string ToString()
        {
            return this.Info();
        }

        public void GetInfo()
        {
            Console.WriteLine(this.Info());
        }
    }
}
