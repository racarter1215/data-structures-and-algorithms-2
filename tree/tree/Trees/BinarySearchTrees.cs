using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Trees
{
    class BinarySearchTrees<T>
    {
        public Node<T> Root { get; set; }

        public BinarySearchTrees()
        {

        }

        public BinarySearchTrees(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

        public List<T> ContainsNode(Node<T> root)
        {
            if (root.LeftChild == null && root.RightChild == null)
            {
                throw new Exception("there are no values in this tree");
            }
            List<T> traversal = new List<T>();
            ContainsNode(traversal, root);
            return traversal;
        }
        public void ContainsNode(List<T> traversal, Node<T> root, int value)
        {
            if (Node == null)
            {
                return false;
            }
            else if(Node == value)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
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
                if (node.LeftChild != null)
                {
                    breadth.Enqueue(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    breadth.Enqueue(node.RightChild);
                }

            }
            return answer;
        }
    }
}
