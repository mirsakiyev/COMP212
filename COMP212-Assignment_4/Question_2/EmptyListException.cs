using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
   public class EmptyListException: Exception
    {
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name): base($"The {name} is empty"){ }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner): base(exception, inner) { }
    }
}
