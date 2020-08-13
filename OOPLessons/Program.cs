using OOPLessons.Models;
using System;
using System.Linq;
using TeamFramework;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 8, 6, 2, 8, 9, 3, 4, };

            //arr.BubbleSort();

            //arr.PrintArray();


            Person person = new Person()
            {
                Name = "Qristine"
            };

            Person person1 = new Person()
            {
                Name = "Karlen"
            };

            Person person2 = new Person()
            {
                Name = "Karlen"
            };

            Console.WriteLine(Person.Counter);
            Console.WriteLine(Person.Description);
            Math
            //Console.WriteLine(Person.Description);
        }
    }
}
