using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lName = "Mirsakiyev";
            string fName = "Aslan";
            int ID = 12345;

            for (int i = 0; i < 70; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("Last Name: {0} First Name: {1} ID:{2}", lName, fName, ID);
            for (int i = 0; i < 70; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
