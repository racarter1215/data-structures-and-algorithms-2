using QueueWithStacks.classes;
using System;
using Xunit;

namespace QueuesWithStacksTest
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPathTest()
        {
            //Arrange
            PseudoQueue test = new PseudoQueue();
            string answer1 = "1";
            string answer2 = "2";
            string answer3 = "3";
            string answer4 = "4";
            string answer5 = "5";
            //Act
            test.Enqueue(answer1);
            test.Enqueue(answer2);
            test.Enqueue(answer3);
            test.Enqueue(answer4);
            test.Enqueue(answer5);
            //Assert
            Assert.Equal()
        }
    }
}
