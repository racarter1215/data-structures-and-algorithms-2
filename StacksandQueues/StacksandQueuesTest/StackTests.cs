using System;
using Xunit;
using StacksAndQueues;

namespace XUnitTestProject1
{
    public class StackTests
    {
        [Fact]
        public void CanPushOnStack()
        {
            // Arrange
            Stack stack = new Stack();
            // Act
            stack.Push("first test");
            // Assert
            Assert.Equal("first test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);

        }

        [Fact]
        public void CanPushMultipleOnStack()
        {
            // Arrange
            Stack stack = new Stack();
            // Act 
            stack.Push("first test");        
            stack.Push("second test");
            stack.Push("third test");
            
            //Assert
            Assert.Equal("first test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);
            Assert.Equal("second test", stack.Top.Value);
            Assert.Equal("third test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);
            Assert.NotNull(stack.Top.Value);

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
