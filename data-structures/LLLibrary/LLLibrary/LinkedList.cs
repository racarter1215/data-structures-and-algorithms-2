using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLLibrary
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Inserts a new node with an O(1) operation into LinkedList
        /// </summary>
        /// <param name="value">value to be strored in the node</param>
        public void Insert(int value)
        {
            Current = Head;
            // create teh new node that needs to be added
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value">searchable value</param>
        /// <returns>response if it exists</returns>
        public bool Includes(int value)
        {
            Current = Head;
            // While loop
            // traverse the linked list and do the comparison
            while (Current != null)
            {
                // check if it's equal to the given value
                if (Current.Value == value)
                {
                    return true;
                }

                // move to the next one
                Current = Current.Next;
            }

            return false;
        }

        /// <summary>
        /// Overriding current behavior of tostring method to output all values in the linked list as a string 
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;
            // StringBuilder class. 
            // why would you use Stringbuilder over string concatination??

            StringBuilder sb = new StringBuilder();

            // start constructing sb
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }

        /// <summary>
        /// This method adds a new node with the given value to the end of the list.
        /// </summary>
        /// <param name="value">The int value to be added to the list</param>
        /// <returns>The list with the appended value</returns>
        public void AppendNumber(int value)
        {
            Node node = new Node(value);
            Current = Head;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
                
            }
        }
        /// <summary>
        /// below is a method that inserts a node into a linked list before first value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="insertValue"></param>
        public void InsertBeforeMiddle(int value, int insertValue)
        {
            Current = Head;

            if(Current.Value == value)
            {
                Insert(insertValue);
                Current = Current.Next;
            }
           
            while (Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    Node node = new Node(insertValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Current.Next;
                }
                Current = Current.Next;
            }
        }
        /// <summary>
        /// below is a method that inserts node after first value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertAfterNode(int value, int newValue)
        {
            while(Current != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Current.Next;

                }
                Current = Current.Next;
            }
            
        }
        /// <summary>
        /// below is a method that displays which node space a value is at. i.e. a ll of 10->20->30 with a k of 1 returns 20.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>an integer expressing the place value</returns>
        public int FindKthFromEnd(int key)
        {
            Node walker = Head;
            Node runner = Head;

            int k = key;
            if (k < 0)
            {
                throw new Exception("K is too low");
            }
            while(k > 0)
            {
                if(runner.Next != null)
                {
                    k--;
                    runner = runner.Next;
                }
                else
                {
                    throw new Exception("K is invalid");
                }
            }
            while(runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next;
            }
            return walker.Value;
        }
    }
}
