using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLinkedListClassLibrary
{
    public class SortedLinkedList
    {
        public ListNode FirstNode{get;set;}
        public ListNode LastNode { get; set; }
        public int Count { get; private set;}


        public void Insert(int ins)
        {
            if (IsEmpty())
            {
                FirstNode = LastNode = new ListNode(ins);
                Count=1;
            }
            else
            {
                if (ins <= FirstNode.Data) //the newly inserted to be the new firstnode
                {
                   
                    FirstNode = new ListNode(ins, FirstNode);
                    Count++;
                }
                else if (ins >= LastNode.Data) // the newly inserted to the new lastnode
                {
                    LastNode = LastNode.Next = new ListNode(ins);
                    Count++;
                }
                else // find the right place for the new node 
                {
                    ListNode current = FirstNode;
                    ListNode insnode = new ListNode(ins);

                    while (current.Next.Next != null && current.Next.Data < ins)
                    {
                        current = current.Next;
                    }
                    insnode.Next = current.Next;
                    current.Next = insnode;
                    Count++;
                }
            }
        }


        public bool Remove(int item)
        {
            if (IsEmpty())
            {
                throw new EmptySortedLinkListException();
            }

            // reset firstNode and lastNode references
            if (FirstNode.Data == item) // the first node is the node need to be removed
            {
                if (FirstNode == LastNode) //the removed node is the only node in the list
                {
                    FirstNode = LastNode = null;
                    Count = 0;
                    return true;
                }
                else
                {
                    FirstNode = FirstNode.Next;
                    Count--;
                    return true;
                }
            }
            else //find the item in the list
               if ((FirstNode.Data < item) && (item<LastNode.Data))
                {
                    ListNode current = FirstNode;
                    while ((current.Next!=null) &&(item>current.Next.Data))
                        current = current.Next;
                if (current.Next.Data == item)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                else return false;
                }
            else return false; // item is less than the first elment or item is greater than the last element
        }


        public bool IsEmpty()
        {
            return FirstNode == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty list");
            }
            else
            {
                Console.Write($"The list: ");

                ListNode current = FirstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
