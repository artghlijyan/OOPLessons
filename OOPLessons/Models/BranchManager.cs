using OOPLessons.BaseModels;
using System.Runtime.CompilerServices;

namespace OOPLessons.Models
{
    class BranchManager : Employee
    {
        public int Id { get; set; }
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

        public override void Speak()
        {
            System.Console.WriteLine("Manager is speaking");
        }

        public new void Walk()
        {
            System.Console.WriteLine("Manager is walking");
        }

        public override object this[int index] { get => base[index]; set => base[index] = value; }
    }
}
