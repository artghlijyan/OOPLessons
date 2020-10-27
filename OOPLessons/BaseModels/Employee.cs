namespace OOPLessons.BaseModels
{
    abstract class Employee : Person
    {
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return $"{base.ToString()} Name - { Name}, Age - { Age}";
        }

        public abstract void Work();
    }
}
