using System;

namespace OOPLessons.Models
{
    public class PersonExample
    {
        private int _age = 0;

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

        static PersonExample()
        {
            Description = "This is Person Class";
            Counter = default;
        }

        public PersonExample() 
        {
            Counter++;
        }

        public PersonExample(string name, int age) : this()
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

        public static implicit operator PersonExample(string name)
        {
            return new PersonExample { Name = name };
        }

        public static implicit operator PersonExample(int age)
        {
            return new PersonExample { Age = age };
        }

        public static explicit operator string(PersonExample p)
        {
            string s = p.Name;
            return s;
        }
    }
}
