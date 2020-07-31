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

        /// <summary>
        /// the below method takes a node out of queue
        /// </summary>
        /// <param name="value"></param>
        public string Dequeue(string value)
        {
            // Create a new Node
            Node node = new Node(value);

            if (Front == null)
            {
                throw new Exception("The Queue is Empty");
            }
            string answer = Front.Value;
            Front = Front.Next;
            return answer;

        }


        /// <summary>
        /// looks at the first node of a queue, if it is there
        /// </summary>
        /// <returns>the value of the first node</returns>
        public string Peek()
        {
            if (Front == null)
            {
                throw new Exception("The Queue is Empty");
            }
            return Front.Value;
        }
        /// <summary>
        /// creates an empty queue
        /// </summary>
        /// <returns>an empty queue</returns>
        public bool IsEmpty()
        {
            Queue queue = new Queue();
            var answer = queue.IsEmpty();
            return answer;
        }
    }
}
