using OOPLessons.DataBases;
using OOPLessons.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();

            db.AddToDb(5);
            db.AddToDb(10.2d);
            db.AddToDb(new Customer { Name = "Valodik" });
            db.AddToDb("Hello");

            db.ReadDb();

            Customer customer = (Customer)db[2];
            Console.WriteLine(customer.Name);

            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("Armenia", "Yerevan");
            pairs.Add("France", "Paris");
            pairs.Add("Indonezia", "Jakarta");

            //string s = pairs["Armenia"];
            //Console.WriteLine(s);
        }
    }
}
