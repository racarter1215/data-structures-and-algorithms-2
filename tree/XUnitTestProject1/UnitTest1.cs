using System;
using System.Collections.Generic;
using tree.Trees;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {/// <summary>
    /// checks to see if an empty tree could be made
    /// </summary>
        [Fact]
        public void MakesEmptyTree()
        {
            //Arrange
            Tree<string> result = new Tree<string>();

            //Assert
            Assert.Null(result.Root);
        }
        /// <summary>
        /// checks to see if a tree with one root can be made
        /// </summary>
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
        /// <summary>
        /// checks to see if a left and right root can be made
        /// </summary>
        [Fact]
        public void AddLeftRightRoot()
        {
            //Arrange
            Tree<char> result = new Tree<char>('a');
            Node<char> leftChild = new Node<char>('b');
            Node<char> rightChild = new Node<char>('c');

            result.Root.LeftChild = leftChild;
            result.Root.RightChild = rightChild;

            //Assert
            Assert.NotNull(result.Root.LeftChild);
            Assert.NotNull(result.Root.RightChild);
            Assert.Equal('b', result.Root.LeftChild.Value);
            Assert.Equal('c', result.Root.RightChild.Value);
        }
        /// <summary>
        /// checks to see if a preOrder traversal can be made
        /// </summary>
        [Fact]
        public void ReturnsPreOrder()
        {
            //Arrange
            Tree<char> result = new Tree<char>();
            Node<char> rootNumber = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            result.Root = rootNumber;

            rootNumber.LeftChild = b;
            rootNumber.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;

            List<char> leafOrder = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f'
            };

            //Act
            List<char> preOrder = result.PreOrder(result.Root);

            //Assert
            Assert.Equal(leafOrder, preOrder);
        }
        /// <summary>
        /// checks to see if an inOrder traversal can be made
        /// </summary>
        [Fact]
        public void ReturnsInOrder()
        {
            //Arrange
            Tree<char> result = new Tree<char>();
            Node<char> rootNumber = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            result.Root = rootNumber;

            rootNumber.LeftChild = b;
            rootNumber.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;

            List<char> leafOrder = new List<char>()
            {
                'd', 'b', 'e', 'a', 'f', 'c', 
            };

            //Act
            List<char> inOrder = result.InOrder(result.Root);

            //Assert
            Assert.Equal(leafOrder, inOrder);
        }
        /// <summary>
        /// checks to see if a postOrder traversal can be made
        /// </summary>
        [Fact]
        public void ReturnsPostOrder()
        {
            //Arrange
            Tree<char> result = new Tree<char>();
            Node<char> rootNumber = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            result.Root = rootNumber;

            rootNumber.LeftChild = b;
            rootNumber.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;

            List<char> leafOrder = new List<char>()
            {
                'd', 'e', 'b', 'f', 'c', 'a'
            };

            //Act
            List<char> postOrder = result.PostOrder(result.Root);

            //Assert
            Assert.Equal(leafOrder, postOrder);
        }

    }
}
