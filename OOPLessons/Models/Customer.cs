using OOPLessons.BaseModels;

namespace OOPLessons.Models
{
    class Customer : Employee
    {
        public override object Clone()
        {
            throw new System.NotImplementedException();
        }

        public override void Work()
        {
            throw new System.NotImplementedException();
        }
    }
}
