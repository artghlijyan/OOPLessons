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
            Point p1 = new Point();

            p1.X = 1;
            p1.Y = 2;

            Point p2 = new Point(1, 2);

            Point p3 = new Point(5, 5);
            p1 = p3;
            p2 = p3; 

            if (p1.Equals(p2))
            {
                Console.WriteLine("Points are eqaul");
            }
            else
            {
                Console.WriteLine("Point are not eqaul");
            }

            string name = "Trump";

            Person person = name;
            person = 40;

            Console.WriteLine(person);
            //person.Name = "Putin";

            //string name1 = (string)person;

            //Console.WriteLine(name1);

            //byte b = 0;

            //int a = 256;

            //b = (byte)a;
            //Console.WriteLine(b);
        }
    }
}
