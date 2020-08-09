using OOPLessons.Models;
using System;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int id1 = 10;
            string id2 = "object id";

            FirstClass firstClass1 = new FirstClass(id1, id2);
            FirstClass firstClass2 = new FirstClass();

            FirstClass firstClass3 = new FirstClass()
            {
                id1 = 50,
                id2 = "100"
            };

            //Console.WriteLine(firstClass3);

            string name = "Qristine";
            Person person = new Person(name, 18);
            person.GetInfo();
        }
    }
}
