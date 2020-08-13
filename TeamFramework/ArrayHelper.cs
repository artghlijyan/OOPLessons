using System;
using System.Collections;
using System.Collections.Generic;

namespace TeamFramework
{
    public static class ArrayHelper
    {
        public static void BubbleSort(this int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        arr.Swap(j - 1, j);
                    }
                }
            }
        }

        private static void Swap(this int[] items, int left, int right)
        {
            if (left < 0 && right < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void PrintArray(this int[] arr)
        {
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        } 
    }
}
