using System;
using UnityEngine;

namespace DSA.Scripts.BinarySearchTree
{
    public class BinaryTree
    {
        #region Node Helper Class

        private class Node
        {
            #region Fields

            internal Node LeftChild;
            internal Node RightChild;
            internal int Value = 0;

            #endregion

            #region Constructor

            public Node(int value)
            {
                Value = value;
            }

            #endregion

            #region ToString

            public override string ToString()
            {
                return $"Node = {Value}";
            }

            #endregion
        }

        #endregion

        #region Fields

        private Node _root;

        #endregion

        #region Add

        public void Add(int value)
        {
            Node node = new Node(value);
            
            if (_root is null)
            {
                _root = node;
                return;
            }
            
            Node current = _root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.LeftChild is null)
                    {
                        current.LeftChild = node;
                        break;
                    }

                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild is null)
                    {
                        current.RightChild = node;
                        break;
                    }

                    current = current.RightChild;
                }
            }
        }

        #endregion

        #region Find

        public bool Find(int value)
        {
            Node current = _root;
            while (current != null)
            {
                if (value < current.Value)
                {
                    current = current.LeftChild;
                }
                else if (value > current.Value)
                {
                    current = current.RightChild;
                }
                else
                {
                    return true;
                }
            }
            
            return false;
        }

        #endregion

        #region TraversePreOrder

        public void TraversePreOrder()
        {
            TraversePreOrder(_root);
        }
        
        private void TraversePreOrder(Node root)
        {
            if (root is null)
            {
                return;
            }
            
            Debug.Log(root);
            TraversePreOrder(root.LeftChild);
            TraversePreOrder(root.RightChild);
        }

        #endregion

        #region TraverseInOrder

        public void TraverseInOrder()
        {
            TraverseInOrder(_root);
        }
        
        private void TraverseInOrder(Node root)
        {
            if (root is null)
            {
                return;
            }
            
            TraverseInOrder(root.LeftChild);
            Debug.Log(root.Value);
            TraverseInOrder(root.RightChild);
        }

        #endregion

        #region TraversePostOrder

        public void TraversePostOrder()
        {
            TraversePostOrder(_root);
        }

        private void TraversePostOrder(Node root)
        {
            if (root is null)
            {
                return;
            }
            
            TraversePostOrder(root.LeftChild);
            TraversePostOrder(root.RightChild);
            Debug.Log(root);
        }

        #endregion

        #region Height

        public int Height()
        {
            return Height(_root);
        }
        
        private int Height(Node root)
        {
            if (root is null)
            {
                return -1;
            }
            
            if (IsLeaf(root))
            {
                return 0;
            }

            return 1 + Mathf.Max(Height(root.LeftChild), Height(root.RightChild));
        }

        #endregion

        #region Min

        public int Min()
        {
            return Min(_root);
        }

        private int Min(Node root)
        {
            if (IsLeaf(root))
            {
                return root.Value;
            }
            
            int left = Min(root.LeftChild);
            int right = Min(root.RightChild);

            return Mathf.Min(Mathf.Min(left, right), root.Value);
        }

        #endregion

        #region IsLeaf

        private bool IsLeaf(Node root)
        {
            return root.LeftChild is null && root.RightChild is null;
        }

        #endregion

        #region Equals

        public bool Equals(BinaryTree other)
        {
            if (other is null)
            {
                return false;
            }
            
            return Equals(_root, other._root);
        }

        private bool Equals(Node first, Node second)
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is not null && second is not null )
            {
                return first.Value == second.Value
                       && Equals(first.LeftChild, second.LeftChild)
                       && Equals(first.RightChild, second.RightChild);
            }

            return false;
        }

        #endregion

        #region IsBinarySearchTree

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(_root, Int32.MinValue, Int32.MaxValue);
        }
        
        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root is null)
            {
                return true;
            }

            if (root.Value < min || root.Value > max)
            {
                return false;
            }

            return IsBinarySearchTree(root.LeftChild, min, root.Value - 1)
                   && IsBinarySearchTree(root.RightChild, root.Value + 1, max);
        }

        #endregion
    }
}
