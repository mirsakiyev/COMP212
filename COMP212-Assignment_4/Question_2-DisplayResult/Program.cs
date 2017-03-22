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
            List test = new List();
            List test2 = new List();

            test.InsertAtFront(7);
            test.InsertAtBack(5);
            test.InsertAtBack(2);
            test.InsertAtBack(4);

            test.Display();
            test.Sort();
            test.Display();

            test2.InsertAtFront(3);
            test2.InsertAtBack(4);
            test2.Display();
            Merge(test, test2).Display();

            
        }

        public static List Merge(List list1, List list2)
        {
            while (!list2.IsEmpty())
            {
                list1.InsertAtBack(list2.RemoveFromFront());                           
            }
            return list1;
        }
    }
}
