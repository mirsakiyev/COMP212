/*
 * Aslan Mirsakiyev
 * 23 March 2017
 * Assignment 4 - Question 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question_2;

namespace Question_2_DisplayResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = "---------------------------------------------------------";
            List testList1 = new List();
            List testList2 = new List();

            testList1.InsertAtFront(7);
            testList1.InsertAtBack(5);
            testList1.InsertAtBack(2);
            testList1.InsertAtBack(4);

            Console.WriteLine("First list");
            testList1.Display();

            testList1.Sort();
            Console.WriteLine("Sort first list");
            testList1.Display();
            Console.WriteLine(separator);

            Console.WriteLine("Second list");
            testList2.InsertAtFront(55);
            testList2.InsertAtBack(42);
            testList2.InsertAtBack(1);
            testList2.Display();

            Console.WriteLine("Sort second list");
            testList2.Sort();
            testList2.Display();
            Console.WriteLine(separator);

            Console.WriteLine("Merge first and second list");
            Merge(testList1, testList2).Display();        
        }
     
        // Merge two lists
        public static List Merge(List list1, List list2)
        {
            while (!list2.IsEmpty())
            {
                list1.InsertAtBack(list2.RemoveFromFront());
                // Remove bellow comments to sort the merged list
                //list1.Sort();                              
            }
            return list1;
        }
    }
}
