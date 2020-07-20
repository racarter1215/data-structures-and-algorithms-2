using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        private Node Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }
        /// <summary>
        /// the below method pushes a node into a queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(string value)
        {
            // Create a new Node
            Node node = new Node(value);

            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {

                Rear.Next = node;
                Rear = node;

            }

        }
    }
}
