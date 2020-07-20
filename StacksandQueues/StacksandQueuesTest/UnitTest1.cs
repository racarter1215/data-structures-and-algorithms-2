using System;
using Xunit;
using StacksAndQueues;

namespace XUnitTestProject1
{
    public class UnitTest1
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
            var answer1 = stack.Push("first test");
            answer2 = stack.Push("second test");
            stack.Push("second test");
            // Assert

            Assert.Equal(answer, stack.Top.Value);
            Assert.NotNull(stack.Top.Value);

        }
    }
}
