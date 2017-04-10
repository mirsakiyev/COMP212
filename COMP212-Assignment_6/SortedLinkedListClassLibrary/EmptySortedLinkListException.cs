using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedListClassLibrary
{
    public class EmptySortedLinkListException: Exception
    {

        public EmptySortedLinkListException() : base("The sorted linked list is empty") { }


        // two-parameter constructor
        public EmptySortedLinkListException(string exception, Exception inner) : base(exception, inner) { }
    }
}
