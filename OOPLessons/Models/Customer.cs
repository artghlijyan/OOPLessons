using OOPLessons.BaseModels;

namespace OOPLessons.Models
{
    class Customer : Person
    {
        // public int Id { get; set; }
        // public string Name { get; set; }
        // public int? Age { get; set; }

        public string Bank { get; set; }
        private new string Name { get; set; }

        public Customer(string name, int age, string bank) : base(name, age)
        {
            Bank = bank;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Bank - {Bank}";
        }

        public new void Method()
        {
            base.Method();
            System.Console.WriteLine(" Bank - " + Bank);
        }
    }
}
