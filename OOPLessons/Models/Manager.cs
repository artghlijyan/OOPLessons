using OOPLessons.BaseModels;

namespace OOPLessons.Models
{
    class Manager : Employee
    {
        public int Id { get; set; }

        public Manager(string name, int age) : base(name, age) { }

        public Manager() { }

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

        public override void Work()
        {
            System.Console.WriteLine("Manager is working");
        }

        public override int GetHashCode()
        {
            return (Name + Id.ToString()).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Manager)
            {
                Manager mng = obj as Manager;
                return mng.Id.Equals(this.Id);
            }

            return false;
        }
    }
}
