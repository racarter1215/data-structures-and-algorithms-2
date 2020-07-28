using System;
using tree.Trees;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MakesEmptyTree()
        {
            //Arrange
            Tree<string> result = new Tree<string>();

            //Assert
            Assert.Null(result.Root);
        }

        [Fact]
        public void MakesTreeWithOneRoot()
        {
            //Arrange
            Tree<string> result = new Tree<string>("One String");

            //Assert
            Assert.NotNull(result.Root);
            Assert.Equal("One String", result.Root.Value);
            Assert.IsType<Node<string>>(result.Root);
        }
    }
}
