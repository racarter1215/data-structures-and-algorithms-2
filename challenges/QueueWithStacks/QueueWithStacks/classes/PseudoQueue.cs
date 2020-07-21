using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using StacksAndQueues;

namespace QueueWithStacks.classes
{
    public class PseudoQueue
    {
        public Stack StackOne { get; set; }
        public Stack StackTwo { get; set; }
        public int Count { get; set; }

		public PseudoQueue()
		{
			StackOne = new Stack();
			StackTwo = new Stack();
			Count = 0;
		}
		public void Enqueue(string value)
		{
			SwapNodes();
			if (Count % 2 == 0)
            {
				StackOne.Push(value);
            }
			else 
            {
				StackTwo.Push(value);
            }
			Count++;
		}

		private void SwapNodes()
        {
			bool even = Count % 2 == 0;
			Stack temp = new Stack();
			for(int i = 0; i < Count; i++)
            {
				if (even)
                {
					temp.Push(StackTwo.Pop());
                }
				else
                {
					temp.Push(StackOne.Pop());
                }
            }
			for(int j = 0; j < Count; j++)
            {
                if (even)
				{
					StackOne.Push(temp.Pop());
                }
                else
                {
					StackTwo.Push(temp.Pop());
                }
            }

        }

		private string Dequeue()
        {
            try
            {

                if (Count % 2 == 0)
                {
                    return StackOne.Pop();
                }
                else
                {
                    return StackTwo.Pop();
                }
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
	}
}
