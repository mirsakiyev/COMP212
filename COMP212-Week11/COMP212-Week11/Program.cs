using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "thank you very much for doing class climate survey";
            string firstCharacterUpper = myStr.CapitalizeFirstCharacter();
            Console.WriteLine(firstCharacterUpper);
        }
    }
}
