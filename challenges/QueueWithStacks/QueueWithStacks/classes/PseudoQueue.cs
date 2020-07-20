using System;
using System.Collections.Generic;
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
        public void Enqueue(string value)
		{

			if (Count % 2 == 0 && StackOne.Top == null)
			{
				StackOne.Push(value);
			}
			else if (Count % 2 == 0 && StackOne.Top != null)
			{
				StackOne.Push(StackTwo.Pop());
				StackTwo.Push(value);
			}
			else
			{
				StackTwo.Push(StackOne.Pop());
				StackOne.Push(value);
			}
			Count++;
		}
	}
}
