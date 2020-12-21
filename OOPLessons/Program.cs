using OOPLessons.BaseModels;
using OOPLessons.IEnumerableIMPLS;
using OOPLessons.Interfaces;
using OOPLessons.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataBase db = new DataBase();

            //db.AddToDb(5);
            //db.AddToDb(10.2d);
            //db.AddToDb(new Customer { Name = "Valodik" });
            //db.AddToDb("Hello");

            //db.ReadDb();

            //Customer customer = (Customer)db[2];
            //Console.WriteLine(customer.Name);

            //Dictionary<string, string> pairs = new Dictionary<string, string>();
            //pairs.Add("Armenia", "Yerevan");
            //pairs.Add("France", "Paris");
            //pairs.Add("Indonezia", "Jakarta");

            //string s = pairs["Armenia"];
            //Console.WriteLine(s);

            //Employee aram = new BranchManager("Aram", 30);
            //Employee lilit = new Receptionist("Lilit", 22);

            //Employee arev = new Intern()
            //{
            //    Name = "Arev",
            //    Age = 19
            //};

            //Console.WriteLine(SalaryCounter.GetSalary(aram));
            //Console.WriteLine(SalaryCounter.GetSalary(lilit));
            //Console.WriteLine(SalaryCounter.GetSalary(arev));

            //Employee emp = new Manager();

            //emp.Speak();  
            //emp.Work

            //Manager manager1 = new Manager
            //{
            //    Id = 1,
            //    Age = 30,
            //    Name = "Aram",
            //    Salary = 300
            //};

            //Manager manager2 = new Manager();

            //manager2 = manager1;

            //object o = manager1.Clone();
            //manager2 = o as Manager;

            //Id[] ids =
            //{
            //    new Id { ID = 5},
            //    new Id { ID = 1},
            //    new Id { ID = 4},
            //    new Id { ID = 2},
            //    new Id { ID = 3}
            //};

            //ReverseSort(ids, new Helpers.IdComparisonHelper());

            //foreach (var item in ids)
            //{
            //    Console.WriteLine(item);
            //}

            int[] items = { 1, 2, 3, 4};

            ImplExample3 impl = new ImplExample3(items);

            foreach (int item in impl)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(new string('_', 10));

            foreach (var item in impl)
            {
                Console.WriteLine(item);
            }
        }

        static void SortArray<T>(T[] arr, IComparer<T> comparer)
        {
            T temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (comparer.Compare(arr[j - 1], arr[j]) > 0)
                    {
                        temp = arr[j -1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void ReverseSort<T>(T[] arr, IComparer<T> comparer)
        {
            SortArray(arr, comparer);
            T temp;

            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }
    }
}