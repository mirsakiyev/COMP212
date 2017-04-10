using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(x => x);

            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
