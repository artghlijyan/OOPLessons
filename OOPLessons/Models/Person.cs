using System;

namespace OOPLessons.Models
{
    class Person
    {
        private int _age;

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

        public Person() { }

        public Person(string name, int age)
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
