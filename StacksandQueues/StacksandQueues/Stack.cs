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

        /// <summary>
        /// the below method pops off the top value of a stack
        /// </summary>
        /// <returns>the popped value</returns>
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
        /// <summary>
        /// looks at the top node of a stack, if it is there
        /// </summary>
        /// <returns>the value of the top node</returns>
        public string Peek()
        {
            if (Top == null)
            {
                throw new Exception("The Stack is Empty");
            }
            return Top.Value;
        }
        /// <summary>
        /// creates an empty stack
        /// </summary>
        /// <returns>an empty stack</returns>
        public bool IsEmpty()
        {
            Queue queue = new Queue();
            var answer = queue.IsEmpty();
            return answer;
        }

    }
}
