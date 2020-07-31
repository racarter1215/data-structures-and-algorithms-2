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
            // Act and Assert
            stack.Push("first test");
            Assert.Equal("first test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);
            stack.Push("second test");
            Assert.Equal("second test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);
            stack.Push("third test");
            Assert.Equal("third test", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);
            

        }

        [Fact]
    }
}
