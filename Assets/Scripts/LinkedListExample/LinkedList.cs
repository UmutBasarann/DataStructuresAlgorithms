using System;

namespace DSA.Scripts.LinkedListExample
{
    public class LinkedList
    {
        #region Node Helper

        private class Node
        {
            #region Fields

            internal int Value;
            internal Node Next;

            #endregion

            #region Constructor

            public Node(int value)
            {
                Value = value;
            }

            #endregion
        }

        #endregion
        
        #region Fields

        private Node _first;
        private Node _last;

        private int _size = 0;

        #endregion

        #region AddLast

        public void AddLast(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                _first = node;
                _last = node;
            }
            else
            {
                _last.Next = node;
                _last = node;
            }

            _size++;
        }

        #endregion

        #region AddFirst

        public void AddFirst(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Next = _first;
                _first = node;
            }

            _size++;
        }

        #endregion

        #region IndexOf

        public int IndexOf(int item)
        {
            int index = 0;
            Node current = _first;

            while (current != null)
            {
                if (current.Value == item)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        #endregion

        #region Contains

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        #endregion

        #region RemoveFirst

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new Exception("NoSuchElementException");
            }

            if (_first == _last)
            {
                _first = _last = null;
            }
            else
            {
                Node second = _first.Next;
                _first.Next = null;
                _first = second;
            }
            
            _size--;
        }

        #endregion

        #region RemoveLast

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new Exception("NoSuchElementException");
            }
            
            if (_first == _last)
            {
                _first = _last = null;
            }
            else
            {
                Node previous = GetPrevious(_last);
                _last = previous;
                _last.Next = null;
            }
            
            _size--;
        }

        #endregion

        #region Size

        public int Size()
        {
            return _size;
        }

        #endregion

        #region ToArray

        public int[] ToArray()
        {
            int[] array = new int[_size];
            Node current = _first;
            int index = 0;

            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }

            return array;
        }

        #endregion

        #region Reverse

        public void Reverse()
        {
            if (IsEmpty())
            {
                return;
            }
            
            Node previous = _first;
            Node current = _first.Next;
            while (current != null)
            {
                Node next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            _last = _first;
            _last.Next = null;
            _first = previous;
        }

        #endregion

        #region Kth Node From the End

        public int KthNodeFromEnd(int k)
        {
            if (IsEmpty())
            {
                throw new Exception("Illegal State Exception");
            }
            
            Node first = _first;
            Node second = _first;

            for (int i = 0; i < k - 1; i++)
            {
                second = second.Next;

                if (second is null)
                {
                    throw new ArgumentException("Illegal Argument Exception");
                }
            }

            while (second != _last)
            {
                first = first.Next;
                second = second.Next;
            }

            return first.Value;
        }

        #endregion

        #region GetPrevious

        private Node GetPrevious(Node node)
        {
            Node current = _first;
            while (current != null)
            {
                if (current.Next == node)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }
        

        #endregion

        #region IsEmpty

        private bool IsEmpty()
        {
            return _first is null;
        }

        #endregion
    }
}
