﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.Test.Trash
{
    class TrashMain
    {
        public static void OldMain() // OOP1
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
            Person tom = new Person(name);


            Console.WriteLine(tom);
        }
    }
}