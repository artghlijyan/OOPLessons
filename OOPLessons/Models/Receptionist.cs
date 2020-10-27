using OOPLessons.BaseModels;

namespace OOPLessons.Models
{
    class Receptionist : Employee
    {
        public Receptionist() { }
        
        public Receptionist(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Work()
        {
            throw new System.NotImplementedException();
        }
    }
}
