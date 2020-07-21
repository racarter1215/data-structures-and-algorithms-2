using QueueWithStacks;
using System;
using Xunit;

namespace QueuesWithStacksTest
{
    public class UnitTest1
    {/// <summary>
    /// below method checks that one can enqueue placed values on odd number placements
    /// </summary>
        [Fact]
        public void EnqueueOddNumberValueTest()
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
            Assert.Equal(answer1, test.Dequeue());
        }

        /// <summary>
        /// below method checks that one can enqueue placed values on even number placements
        /// </summary>
        [Fact]
        public void EnqueueEvenNumberValueTest()
        {
            //Arrange
            PseudoQueue test = new PseudoQueue();
            string answer1 = "1";
            string answer2 = "2";
            string answer3 = "3";
            string answer4 = "4";

            //Act
            test.Enqueue(answer1);
            test.Enqueue(answer2);
            test.Enqueue(answer3);
            test.Enqueue(answer4);

            //Assert
            Assert.Equal(answer1, test.Dequeue());
        }
        /// <summary>
        /// below method checks that one can enqueue multiple values at once
        /// </summary>
        [Fact]
        public void EnqueueMultipleNumberValueTest()
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

            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();

            //Assert
            Assert.Equal(answer5, test.Dequeue());
        }
        /// <summary>
        /// below method checks that one can enqueue and dequeue values on alternating pattern
        /// </summary>
        [Fact]
        public void AlternatingEnqueueDequeueNumberValueTest()
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

            test.Dequeue();
            test.Dequeue();
            test.Dequeue();

            string answer6 = "6";
            string answer7 = "7";
            test.Enqueue(answer6);
            test.Enqueue(answer7);


            //Assert
            Assert.Equal(answer4, test.Dequeue());
        }
        /// <summary>
        /// below method checks that the throw exception in dequeue() works
        /// </summary>
        [Fact]
        public void DequeueThrowExceptionTest()
        {
            //Arrange
            PseudoQueue test = new PseudoQueue();

            //Assert
            Assert.Throws<NullReferenceException>(() => test.Dequeue());
        }
    }




}
