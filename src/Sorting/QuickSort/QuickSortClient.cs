using System;
using System.Collections.Generic;

namespace Sorting.QuickSort
{
    public class QuickSortClient
    {
        public List<int> RandomList(int size)
        {
            var ret = new List<int>(size);
            var rand = new Random(1);
            for (int i = 0; i < size; i++)
            {
                ret.Add(rand.Next(size));
            }
            return ret;
        }

        static int MyPartition(List<int> list, int left, int right)
        {
            var start = left;
            var pivot = list[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && list[left] <= pivot)
                    left++;

                while (left <= right && list[right] > pivot)
                    right--;

                if (left > right)
                {
                    list[start] = list[left - 1];
                    list[left - 1] = pivot;

                    return left;
                }


                var temp = list[left];
                list[left] = list[right];
                list[right] = temp;

            }
        }

        public void MyQuickSort(List<int> list, int left, int right)
        {
            while (true)
            {
                if (list == null || list.Count <= 1)
                    return;

                if (left >= right) return;
                var pivotIdx = MyPartition(list, left, right);
                MyQuickSort(list, left, pivotIdx - 1);
                left = pivotIdx;
            }
        }

        public void DumpList(List<int> list)
        {
            list.ForEach(delegate(int val)
            {
                Console.Write(val);
                Console.Write(", ");
            });
            Console.WriteLine();
        }
    }

    public class BubbleSortClient
    {
        public int BubbleSort()
        {
            Console.Write("\nProgram for Ascending order of Numeric Values using BUBBLE SORT");
            Console.Write("\n\nEnter the total number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1) + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before Sorting   : ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < max - i; j++)
                {
                    if (numarray[j] > numarray[j + 1])
                    {
                        int temp = numarray[j];
                        numarray[j] = numarray[j + 1];
                        numarray[j + 1] = temp;
                    }
                }
                Console.Write("After iteration " + i + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("/*** " + (i + 1) + " biggest number(s) is(are) pushed to the end of the array ***/\n");
            }

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1) + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            return 0;
        }  
    }
}
