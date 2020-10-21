using OOPLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.BaseModels
{
    class Employee : Person
    {
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return $"{base.ToString()} Name - { Name}, Age - { Age}";
        }

        public override void Speak()
        {
            Console.WriteLine("Employee's Speak");
        }

        public virtual object this[int index]
        {
            get { return new object(); }
            set { /* set the specified index to value here */ }
        }
    }
}
