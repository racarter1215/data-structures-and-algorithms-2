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
    }
}
