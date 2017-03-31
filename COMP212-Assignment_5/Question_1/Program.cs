using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        // overloading generic method exercise
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("Array intArray contains:");
            DisplayArray(intArray);

            Console.WriteLine("Array doubleArray contains:");
            DisplayArray(doubleArray);

            Console.WriteLine("Array charArray contains:");
            DisplayArray(charArray);

        }
        private static void DisplayArray <T>(T[] inputArray)
        {
            foreach (T element in inputArray)
                Console.Write(element+" ");

            Console.WriteLine("\n");
        }

        /* Explain following items :
         * 
         * ICollection - The ICollection<T> interface is the base interface for classes
         *               in the System.Collections.Generic namespace. The ICollection<T> interface 
         *               extends IEnumerable<T> and is extended by IDictionary<TKey, TValue> and IList<T>
         *               
         * Array - Provides methods for creating, manipulating, searching, and sorting arrays,
         *         thereby serving as the base class for all arrays in the common language runtime.
         *         
         * IList - An IList<T> implementation is a collection of values, and its members
         *         can be accessed by index, like the List<T> class
         *         
         * Load factor - 
         * Hash-table collision -
         * Space/time trade-off in hashing -
         * 
         * Dictionary - Represents a collection of keys and values.
         */

    }
}
