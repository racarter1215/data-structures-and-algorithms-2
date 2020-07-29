using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace tree.Trees
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {

        }

        public BinaryTree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }
        /// <summary>
        /// checks to see if tree has values, and if so, sets up a PreOrder traversal with a blank list
        /// </summary>
        /// <param name="root">the top number of a tree</param>
        /// <returns>the traversal list of values</returns>
        public List<T> PreOrder(Node<T> root)
        {
            if (root.LeftChild == null && root.RightChild == null)
            {
                throw new Exception("there are no values in this tree");
            }
            List<T> traversal = new List<T>();
            PreOrder(traversal, root);
            return traversal;
        }
        /// <summary>
        /// this allows one to traverse a tree from the root down (left, then right)
        /// </summary>
        /// <param name="traversal">the traversal value list</param>
        /// <param name="root">the top number of the tree</param>
        private void PreOrder(List<T> traversal, Node<T> root)
        {
            traversal.Add(root.Value);

            if(root.LeftChild != null)
            {
                PreOrder(traversal, root.LeftChild);
            }
            if(root.RightChild != null)
            {
                PreOrder(traversal, root.RightChild);
            }
        }

        /// <summary>
        /// checks to see if tree has values, and if so, sets up an InOrder traversal with a blank list
        /// </summary>
        /// <param name="root">the top number of a tree</param>
        /// <returns>the traversal list of values</returns>
        public List<T> InOrder(Node<T> root)
        {
            if (root.LeftChild == null && root.RightChild == null)
            {
                throw new Exception("there are no values in this tree");
            }
            List<T> traversal = new List<T>();
            InOrder(traversal, root);
            return traversal;
        }
        /// <summary>
        /// this allows one to traverse a tree from the bottom left up (left, then when right child found, right)
        /// <param name="traversal">the traversal value list</param>
        /// <param name="root">the top number of the tree</param>
        private void InOrder(List<T> traversal, Node<T> root)
        {            
            if (root.LeftChild != null)
            {
                InOrder(traversal, root.LeftChild);
            }

            traversal.Add(root.Value);

            if (root.RightChild != null)
            {
                InOrder(traversal, root.RightChild);
            }
        }
        /// <summary>
        /// checks to see if tree has values, and if so, sets up an PostOrder traversal with a blank list
        /// </summary>
        /// <param name="root">the top number of a tree</param>
        /// <returns>the traversal list of values</returns>
        public List<T> PostOrder(Node<T> root)
        {
            if (root.LeftChild == null && root.RightChild == null)
            {
                throw new Exception("there are no values in this tree");
            }
            List<T> traversal = new List<T>();
            PostOrder(traversal, root);
            return traversal;
        }
        /// <summary>
        /// this allows one to traverse a tree from the bottom left up (left, then right, even if you didn't discover it from a root)
        /// <param name="traversal">the traversal value list</param>
        /// <param name="root">the top number of the tree</param>
        private void PostOrder(List<T> traversal, Node<T> root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PostOrder(traversal, root.RightChild);
            }
            traversal.Add(root.Value);
        }
        /// <summary>
        /// the below method checks each node in a tree and returns the largest value found
        /// </summary>
        /// <param name="root">the value of the node being checked</param>
        /// <returns>the max value</returns>
        private int MaxValue(Node<int> root)
        {
            int answer = root.Value;
            Queue<Node<int>> breadth = new Queue<Node<int>>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out _))
            {
                Node<int> node = breadth.Dequeue();

                if (node.Value > answer)
                {
                    answer = node.Value;
                }
                if(node.LeftChild != null)
                {
                    breadth.Enqueue(node.LeftChild);
                }
                if(node.RightChild != null)
                {
                    breadth.Enqueue(node.RightChild);
                }
                
            }
            return answer;
        }
    }
}
