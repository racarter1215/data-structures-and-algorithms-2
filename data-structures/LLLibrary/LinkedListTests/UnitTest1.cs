using System;
using Xunit;
using LLLibrary;
using System.Transactions;

namespace LinkedListTests
{
    public class UnitTest1
    {//below checks to see if an empty node can be made
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }
        //below checks to see if an node can be inserted into linked list
        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }
        //below checks to see if multiple nodes can be put into linked list
        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);

        }
        //below checks to see if a value can be found in linked list
        [Fact]
        public void CanFindValueInList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 15;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);

        }
        //below shows what happens when a value cannot be found in linked list
        [Fact]
        public void CannotFindValueInLinkedList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);

        }
        //below checks to see if all values in linked list can be returned
        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";
            // Assert
            Assert.Equal(expected, value);

        }
        //below checks to see if a linked list can have a node appended to it
        [Fact]
        public void CanAppendToLinkedList()
        {
            //append means add to the end
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            // Act
            list.AppendNumber(4);
            // Assert
            Assert.Equal(4, list.Current.Next.Value);
        }

        [Fact]
        //below checks to see if multiple nodes can be appended to it
        public void CanAppendMultipleToLinkedList()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(8);
            list.Insert(15);
            list.AppendNumber(16);
            list.Insert(23);
            list.Insert(42);
            list.AppendNumber(11);
            list.AppendNumber(31);

            //Act
            string expectedOutcome = "42 -> 23 -> 15 -> 8 -> 16 -> 11 -> 31 -> NULL";

            //Assert
            Assert.Equal(expectedOutcome, list.ToString());
        }
        //below checks to see if a node can be appended before the middle of a linked list
        [Fact]

        public void CanAppendBeforeMiddleLinkedList()
        {
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            list.Insert(23);
            list.Insert(16);
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            //insertBefore
            list.InsertBeforeMiddle(15, 42);

            //Arrange
            string expected = "4 -> 8 -> 42 -> 15 -> 16 -> 23 -> NULL";
            Assert.Equal(expected, list.ToString());
        }
        //below checks to see if an node can be inserted before fisrt node in a linked list
        [Fact]

        public void InsertNodeBeforeFirstNode()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            //Act
            list.InsertBeforeMiddle(6, 7);

            string expected = "7 -> 6 -> 5 -> 4 -> NULL";

            //Assert
            Assert.Equal(expected, list.ToString());
        }
        //below checks to see if node can be inserted into a linked list after an existing node
        [Fact]

        public void InsertNodeAfterExistingNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            list.InsertAfterNode(15, 100);

            string expected = "16 -> 15 -> 100 -> 8 -> 4 -> NULL";

            //Assert
            Assert.Equal(expected, list.ToString());
        }
        //below checks to see if a node can be inserted after the last node of a linked list
        [Fact]

        public void InsertNodeAfterLastNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);

            list.InsertAfterNode(4, 100);

            string expected = "16 -> 15 -> 8 -> 4 -> 100 -> NULL";

            //Assert
            Assert.Equal(expected, list.ToString());
        }
        //below checks to see if a value can be returned after the "Happy Path" is followed
        [Fact]

        public void ItCanReturnValueFromEndOfHappyPath()
        {
            LinkedList list = new LinkedList();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            //Act
            int value = list.FindKthFromEnd(1);

            //Assert
            Assert.Equal(20, value);
        }
        //below checks to see if an exception throws from a value of equal list length given
        [Fact]

        public void CanReturnExceptionForEqualLength()
        {
            LinkedList list = new LinkedList();

            //Arrange

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            //Act
            
            var ex = Assert.Throws<Exception>(() => list.FindKthFromEnd(5));

            //Assert
            Assert.Equal("K is invalid", ex.Message);
        }
        //below checks to see if an exception is thrown if the value is larger than length of linked list
        [Fact]

        public void KIsGreaterThanLengthOfList()
        {
            LinkedList list = new LinkedList();

            //Arrange

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            //Act
            var test = Assert.Throws<Exception>(() => list.FindKthFromEnd(6));

            //Assert
            Assert.Equal("K is invalid", test.Message);
        }
        //below checks to see if an exception is thrown by a negative number
        [Fact]
        public void KIsNotPositiveInteger()
        {
            LinkedList list = new LinkedList();

            //Arrange

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            //Act

            var ex = Assert.Throws<Exception>(() => list.FindKthFromEnd(-7));

            //Assert
            Assert.Equal("K is too low", ex.Message);
        }
        //below checks to see if an exception is thrown if the linked list is one node long
        [Fact]
        public void LinkedListSizeOfOne()
        {
            LinkedList list = new LinkedList();

            //Arrange

            list.Insert(10);

            //Act

            int value = list.FindKthFromEnd(0);

            //Assert
            Assert.Equal(10, value);
        }

    }
}
