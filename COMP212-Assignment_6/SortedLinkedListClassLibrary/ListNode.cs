using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedListClassLibrary
{
    public class ListNode
    {
        public int Data { get;}

        public ListNode Next { get; set; }

        public ListNode(int dataValue) : this(dataValue, null) { }

        public ListNode(int dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
