using OOPLessons.BaseModels;

namespace OOPLessons.Models
{
    class Employee : Customer
    {
        public string WorkPlace { get; set; }

        public Employee()
        {
            Name
            System.Console.WriteLine("Emplpoyee ctor");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, WorkPlace - {WorkPlace}";
        }
    }
}
