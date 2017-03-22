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
            string separator = "------------------------------------------------";
            // Create stack called lego
            Stack<string> lego = new Stack<string>();         
            // After adding the first brick we cannot remove it
            // untill we remove brick 2 and brick 3
            lego.Push("Brick 1");            
            lego.Push("Brick 2");
            lego.Push("Brick 3");
            // Displays all elements in the stack(lego)
            Console.WriteLine("All elements in the stack:");
            foreach (string i in lego)
            {                            
                Console.WriteLine(i);
            }
            Console.WriteLine(separator);

            Console.WriteLine("Elements in the stack after lego.Peek():");
            string peek = lego.Peek(); // Returns the object at the top of the Stack without removing it.
            Console.WriteLine(peek);
            Console.WriteLine(separator);

            Console.WriteLine("Element that got removed from the stack after lego.Pop(): ");
            Console.WriteLine(lego.Pop()); // Removes and returns the object at the top of the Stack.
            Console.WriteLine(separator);

            Console.WriteLine("Elements in the stack after lego.Peek():");
            string peekAfterPop = lego.Peek(); // Returns the object at the top of the Stack without removing it.
            Console.WriteLine(peekAfterPop);
            Console.WriteLine(separator);
            Console.WriteLine();
            Console.WriteLine();           


            // Create an object of a Queue<string> called queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Adam"); // Add to the back
            queue.Enqueue("Sam");
            queue.Enqueue("Jordan");
            Console.WriteLine("All elements in the queue:");
            foreach (var item in queue.ToArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(separator);

            Console.WriteLine("Elements in the queue after queue.Dequeue():");
            queue.Dequeue();//removes the front item
            foreach (var item in queue.ToArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(separator);
        }
    }
}
