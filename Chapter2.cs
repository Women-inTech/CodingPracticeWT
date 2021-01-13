using System;
using System.Collections.Generic;

namespace CCI
{
    class Chapter2

    {
        // 2.1 Write code to remove duplicates from an unsorted linked list.

        static public LinkedList<int> RemoveDuplicates(LinkedList<int> l)
        {
            if (l == null || l.First == null)
                return l;

            LinkedListNode<int> head = l.First;

            if (head.Next == null)
                return l;

            Dictionary<int, int> myDict = new Dictionary<int, int>();
            LinkedList<int> newList = new LinkedList<int>();



            while (head.Next != null)
            {
                if (!myDict.ContainsKey(head.Value))
                {
                    myDict.Add(head.Value, 0);
                    newList.AddLast(new LinkedListNode<int>(head.Value));
                }

                head = head.Next;
            }

            return newList;
        }


        // 2.1.1 Write code to remove ALL element duplicates from an unsorted linked list.

        static public LinkedList<int> RemoveAllDuplicates(LinkedList<int> l)
        {
            if (l == null || l.First == null)
                return l;

            LinkedListNode<int> head = l.First;

            if (head.Next == null)
                return l;

            Dictionary<int, int> myDict = new Dictionary<int, int>();
            LinkedList<int> newList = new LinkedList<int>();



            while (head.Next != null)
            {
                if (!myDict.ContainsKey(head.Value))
                {
                    myDict.Add(head.Value, 1);
                }
                else
                {
                    myDict[head.Value]++;
                }

                head = head.Next;
            }

            foreach (int k in myDict.Keys)
            {
                if (myDict[k] == 1)
                {
                    newList.AddLast(new LinkedListNode<int>(k));
                }
            }

            return newList;
        }



        // 2.2 Implement an algorithm to find the kth to last element of a singly linked list
        //return null if is not possible

        static public LinkedListNode<int> ReturnKthElement(LinkedList<int> l, int k)
        {
            if (l == null || l.First == null || k < 0)
                return null;
            LinkedListNode<int> a = null, b = l.First;
            int i = 1;
            while (b.Next != null)
            {
                if (i == k)
                {
                    a = l.First;
                    i++;
                    continue;
                }
                if (i > k)
                {
                    a = a.Next;
                }
                b = b.Next;
                i++;
            }

            if (a == null)
            {
                Console.WriteLine("k > length of the list");
            }
            return a;
        }

        /// <summary>
        /// Return middle node
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        static public LinkedListNode<int> ReturnMiddleElement(LinkedList<int> l)
        {
            if (l == null || l.First == null)
                return null;
            LinkedListNode<int> a = l.First, b = l.First;
            while (b.Next != null)
            {
                b = b.Next;
                if (b.Next != null)
                {
                    b = b.Next;
                }
                else
                {
                    return a;
                }
                a = a.Next;
            }
            return a;
        }

        /// <summary>
        /// Delete middle node
        /// </summary>
        /// <param name="args"></param>
        /// 
        static public void DeleteMiddleElement(LinkedList<int> l)
        {
            if (l == null || l.First == null)
                return;
            if (l.First.Next == null)
            {
                l.RemoveFirst();
                return;
            }
            if(l.First.Next.Next == null)
            {
                l.RemoveFirst();
                return;
            }
            LinkedListNode<int> a = l.First, b = l.First;
            while (b.Next != null)
            {
                b = b.Next;
                if (b.Next != null)
                {                    
                    b = b.Next;
                }
                else
                {
                    l.Remove(a);
                    return;

                }
                a = a.Next;
            }
            l.Remove(a);
        }


        //2.4 Write code to partition a linked list around a value x.

        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddLast(new LinkedListNode<int>(1));
           // myList.AddLast(new LinkedListNode<int>(2));
            //myList.AddLast(new LinkedListNode<int>(3));
            //myList.AddLast(new LinkedListNode<int>(4));
            //myList.AddLast(new LinkedListNode<int>(5));
            //myList.AddLast(new LinkedListNode<int>(6));
           // myList.AddLast(new LinkedListNode<int>(7));
            //myList.AddLast(new LinkedListNode<int>(8));
            //myList.AddLast(new LinkedListNode<int>(9));
            //myList.AddLast(new LinkedListNode<int>(10));

            foreach (int i in myList)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine("\n");

            //            LinkedList<int> result= RemoveAllDuplicates(myList);
            DeleteMiddleElement(myList);
            
            foreach (int i in myList)
            {
                Console.Write(i + " -> ");
         }
        }
    }
}
