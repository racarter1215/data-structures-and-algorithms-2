using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StacksAndQueues;


namespace XUnitTestProject1
{

    public class QueueTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("test 1");
            que.Enqueue("test 2");

            // Assert
            Assert.Equal("test", que.Front.Value);
        }
        [Fact]
        public void CanEnqueueMultipleIntoQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("test 1");
            que.Enqueue("test 2");

            // Assert
            Assert.Equal("test 1", que.Front.Value);
        }
        [Fact]
        public void CanPopOffStack()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push("first test");
            stack.Push("second test");
            //Act
            string answer = stack.Pop();
            //Assert
            Assert.Equal("second test", answer);
        }

        [Fact]
        public void CanEmptyStack()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push("first test");
            stack.Push("second test");
            stack.Push("third test");
            stack.Push("fourth test");
            //Act
            string answer1 = stack.Pop();
            string answer2 = stack.Pop();
            string answer3 = stack.Pop();
            string answer4 = stack.Pop();
            //Assert
            Assert.Equal("first test", answer1);
            Assert.Equal("second test", answer2);
            Assert.Equal("third test", answer3);
            Assert.Equal("fourth test", answer4);
            Assert.Null(stack.Top);
        }

        [Fact]
        public void PeekOnStack()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push("first test");
            stack.Push("second test");
            //Act
            string answer = stack.Peek();
            //Assert
            Assert.Equal("second test", answer);
        }

        [Fact]
        public void CreateEmptyStack()
        {
            Stack stack = new Stack();
            bool answer = stack.IsEmpty();
        }

        [Fact]
        public void PopPeekException()
        {
            //Arrange
            Stack stack = new Stack();
            //Act
            var answer1 = Assert.Throws<Exception>(() => stack.Pop());
            var answer2 = Assert.Throws<Exception>(() => stack.Peek());
            //Assert
            //Assert.Equal(a, answer1);
            Assert.Equal("The Stack is Empty", (System.Collections.Generic.IEnumerable<char>)answer2);
        }

    }
}
