namespace OOPLessons.BaseModels
{
    abstract class Employee : Person
    {
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract void Work();
    }
}
