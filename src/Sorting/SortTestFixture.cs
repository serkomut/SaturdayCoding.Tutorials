using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using NUnit.Framework;
using Sorting.QuickSort;

namespace Sorting
{
    [TestFixture]
    public class SortTestFixture
    {
        private QuickSortClient quickSort = new QuickSortClient();
        private BubbleSortClient bubbleSort = new BubbleSortClient();
        //http://www.softwareandfinance.com/CSharp/QuickSort_Recursive.html
        [Test]
        public void QuickSorter()
        {
            var list = quickSort.RandomList(1000);
            quickSort.MyQuickSort(list, 0, list.Count - 1);
            quickSort.DumpList(list);
        }

        [Test]
        public void BubbleSorter()
        {
            bubbleSort.BubbleSort();
        }

        private static void PrintType<T>(T first, T second)
        {
            Console.WriteLine(typeof (T));
        }

        [Test]
        public void PrintTest()
        {
           
            var view = new GridView();
            var link = new HyperLink();
            var person = new Person();
            PrintType(1, new object());
        }

    }

    public class Person
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}