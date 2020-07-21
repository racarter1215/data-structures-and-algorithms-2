using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }
        /// <summary>
        /// the below method pushes a node to the top of a stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(string value)
        {
            // Create a new node
            Node node = new Node(value);
            node.Next = Top;
            Top = node;

        }

        public string Pop()
        {
            try
            {
                Node temp = Top;
                Top = Top.Next;
                return temp.Value;
            }
            catch(NullReferenceException a)
            {
                throw a;
            }
        }
    }
}
