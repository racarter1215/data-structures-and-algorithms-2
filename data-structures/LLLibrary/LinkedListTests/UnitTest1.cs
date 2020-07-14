using System;
using Xunit;
using LLLibrary;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

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
            string expectedOutput = "8 -> 15 -> 16 -> 23 -> 42 -> 4 -> NULL";
            string answer = list.ToString();
            // Assert
            Assert.Equal(expectedOutput, answer);
        }

        [Fact]

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
            string expectedOutcome = "8 -> 15 -> 23 -> 42 -> 16 -> 11 -> 31 -> NULL";

            //Assert
            Assert.Equal(expectedOutcome, list.ToString());
        }

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
            string expected = "23 -> 16 -> 42 -> 15 -> 8 -> 4 -> NULL";
            Assert.Equal(expected, list.ToString());
        }
    }
}
