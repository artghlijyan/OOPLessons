using OOPLessons.Models;
using OOPLessons.Struct;
using System;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "give";
            string s1 = s;
            s1 = "Give";

            string k = "give";
            ref string k1 = ref k;
            k1 = "Give";
            Console.WriteLine(k);
        }
    }
}
