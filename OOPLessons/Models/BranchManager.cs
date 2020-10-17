using OOPLessons.BaseModels;
using System.Runtime.CompilerServices;

namespace OOPLessons.Models
{
    class BranchManager : Employee
    {
        public BranchManager(string name, int age) : base(name, age) { }

        public BranchManager() { }

        public override string ToString()
        {
            return base.ToString();
        }

        public void DoSomething()
        {
            System.Console.WriteLine("Hello");
        }
    }
}
