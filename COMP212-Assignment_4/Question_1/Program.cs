using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> lego = new Stack<string>();
            // after adding the first brick we cannot remove it
            // untill we remove brick 2 and brick 3
            lego.Push("Brick 1");
            lego.Push("Brick 2");
            lego.Push("Brick 3");

            lego.Pop();

            string peek = lego.Peek();
            Console.WriteLine(peek);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Adam"); //add to the back
            queue.Enqueue("Sam");

            foreach (var item in queue.ToArray())
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();//removes the front item
            Console.WriteLine();
            foreach (var item in queue.ToArray())
            {
                Console.WriteLine(item);
            }
        }
    }
}
