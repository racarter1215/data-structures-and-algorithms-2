using System;
using System.Collections.Generic;
using System.Text;

namespace LLZip
{
    class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }
}
