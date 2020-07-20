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

    }
}
