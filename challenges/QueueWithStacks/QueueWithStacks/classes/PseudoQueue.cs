using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using StacksAndQueues;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        private Stack StackOne { get; set; }
        private Stack StackTwo { get; set; }
        private int Count { get; set; }
        private bool StackOneLastPopped { get; set; }

		public PseudoQueue()
		{
			StackOne = new Stack();
			StackTwo = new Stack();
			Count = 0;
            StackOneLastPopped = false;
		}
        /// <summary>
        /// the below method allows for a value to be placed into the PseudoQueue
        /// </summary>
        /// <param name="value"></param>
		public void Enqueue(string value)
		{
            int depth = Count / 2;
            Stack shuffledStack = Count % 2 == 0 ? StackOne : StackTwo;
            Stack temp = new Stack();
            for (int i = 0; i < depth; i++)
            {
                temp.Push(shuffledStack.Pop());
            }
            shuffledStack.Push(value);
            for (int j = 0; j < depth; j++)
            {
                shuffledStack.Push(temp.Pop());
            }
            Count++;
		}
        /// <summary>
        /// the below method removes an value from the PseudoQueue
        /// </summary>
        /// <returns>the removed value</returns>
        public string Dequeue()
        {
            try
            {
                string returnValue;
                if (StackOneLastPopped)
                {
                    StackOneLastPopped = !StackOneLastPopped;
                    returnValue = StackTwo.Pop();
                }
                else
                {
                    StackOneLastPopped = !StackOneLastPopped;
                    returnValue = StackOne.Pop();
                }
                Count--;
                return returnValue;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
	}
}
