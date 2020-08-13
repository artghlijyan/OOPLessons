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
            int[] arr = { 1, 8, 6, 2, 8, 9, 3, 4, };

            arr.BubbleSort();

            arr.PrintArray();
        }
    }
}
