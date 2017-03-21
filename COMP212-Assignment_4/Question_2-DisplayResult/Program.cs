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
            //List<string> test = new List<string>();
            List test = new List();
            //List test2 = new List();
            test.InsertAtFront("one");
            test.InsertAtBack("two");
            test.Display();
        }
    }
}
