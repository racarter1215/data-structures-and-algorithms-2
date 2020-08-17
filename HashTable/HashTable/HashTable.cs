using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HashTable
{
    public class HashTable<T>
    {
        public LinkedList<LinkedListNode<Node<T>>>[] Map { get; set; }

        public HashTableMethod(int size)
        {
            Map = new LinkedList<LinkedListNode<Node<T>>>[size];
        }

    }

}
