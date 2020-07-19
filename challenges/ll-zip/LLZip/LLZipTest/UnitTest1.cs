using System;
using Xunit;
using LLLibrary;
using static LLZip.Program;

namespace LLZipTest
{
    public class UnitTest1
    {//below tests if the lists can be ziped together in an alternating patter
        [Fact]
        public void Test1()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(1);
            list1.Insert(2);
            list1.Insert(3);


            list2.Insert(4);
            list2.Insert(5);
            list2.Insert(6);

            Node answer = zipLists(list1, list2);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "3 -> 6 -> 2 -> 5 -> 1 -> 4 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());

        }
        //below tests if the lists can be zipped together in an alternating pattern if they start at different lengths
        [Fact]
        public void Test2()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(1);
            list1.Insert(2);
            


            list2.Insert(4);
            list2.Insert(5);
            list2.Insert(6);

            Node answer = zipLists(list1, list2);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "2 -> 6 -> 1 -> 5 -> 4 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }
        //below tests if the lists can be zipped together in an alternating pattern if one list is empty

        [Fact]
        public void Test3()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list2.Insert(4);
            list2.Insert(5);
            list2.Insert(6);

            Node answer = zipLists(list1, list2);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "6 -> 5 -> 4 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }
    }
}
