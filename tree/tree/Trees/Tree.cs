using System;
using System.Collections.Generic;
using System.Text;

namespace tree.Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {

        }

        public Tree(T value)
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

    }
}
