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
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'A', 'S', 'L', 'A', 'N' };

            Console.WriteLine("Array intArray contains:");
            displayArray(intArray);

            Console.WriteLine("Array doubleArray contains:");
            displayArray(doubleArray);

            Console.WriteLine("Array charArray contains:");
            displayArray(charArray);

            explainItems();

        }

        private static void displayArray <T>(T[] inputArray)
        {
            foreach (T element in inputArray)
                Console.Write(element+" ");

            Console.WriteLine("\n");
        }

        /* Explain following items :
         * ICollection           
         * Array 
         * IList 
         * Load factor         
         * Hash-table collision                
         * Space/time trade-off in hashing
         * Dictionary
         */
        private static void explainItems()
        {
            Console.WriteLine("ICollection - The ICollection<T> interface is the base interface for classes\nin the System.Collections.Generic namespace. The ICollection<T> interface\nextends IEnumerable<T> and is extended by IDictionary<TKey, TValue> and IList<T>");
            Console.WriteLine();
            Console.WriteLine("Array - Provides methods for creating, manipulating, searching, and sorting arrays,\nthereby serving as the base class for all arrays in the common language runtime.");
            Console.WriteLine();
            Console.WriteLine("IList - An IList<T> implementation is a collection of values, and its members\ncan be accessed by index, like the List<T> class");
            Console.WriteLine();
            Console.WriteLine("Load factor  - The load factor is a measure of how full the hash table is allowed to get before\nits capacity is automatically increased. When the number of entries in the hash table\nexceeds the product of the load factor and the current capacity, the hash table is rehashed\n(that is, internal data structures are rebuilt) so that the hash table has approximately\ntwice the number of buckets.");
            Console.WriteLine();
            Console.WriteLine("Hash-table collision - Hash tables store both the key and the value in the hash table itself.\nThis way later on during operations such as hash table look-ups it can be guaranteed that \nthe value found is the one that matches the index used for the look-up. Hash tables\nuse a simple 'try the basic method of look-upuntil success' methodology.");
            Console.WriteLine();
            Console.WriteLine("Dictionary - Represents a collection of keys and values.");
            Console.WriteLine();
        }     
    }
}
