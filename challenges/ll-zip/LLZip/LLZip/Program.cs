using System;
using System.Collections.Generic;
using LLLibrary;

namespace LLZip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static Node zipLists(LinkedList list1, LinkedList list2)
        {
            list1.Current = list1.Head;
            list2.Current = list2.Head;
            Node temp1 = new Node(1);
            
            if(list1.Current == null)
            {
                list1.Current = list2.Current;
                list1.Head = list2.Head;
                return list1.Head;
            }
            while(list1.Current.Next != null)
            {
                
                if(list2.Current != null)
                {
                    temp1 = list1.Current.Next;
                    list1.Current.Next = list2.Current;
                    list2.Head = list2.Current.Next;
                    list1.Current.Next.Next = temp1;
                    list1.Current = list1.Current.Next.Next;
                    list2.Current = list2.Head;
                }
                else
                {
                    list1.Current = list1.Current.Next;
                }
            }
            if(list2.Current != null)
            {
                list1.Current.Next = list2.Current;
            }

            return list1.Head;
           
        }
    }
}
