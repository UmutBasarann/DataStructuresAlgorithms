using System;
using UnityEngine;

namespace DSA.Scripts.Array
{
    public class DynamicArray
    {
        #region Fields

        private int[] _items;
        private int _count = 0;

        #endregion

        #region Constructor

        public DynamicArray(int length)
        {
            _items = new int[length];
        }

        #endregion

        #region Insert

        public void Insert(int item)
        {
            if (_items.Length == _count)
            {
                int[] newItems = new int[_count * 2];

                for (int i = 0; i < _count; i++)
                {
                    newItems[i] = _items[i];
                }

                _items = newItems;
            }
            
            _items[_count++] = item;
        }

        #endregion

        #region Index Of

        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

        #region Remove At

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentException("Given index is not in bounds of the array!");
            }

            for (int i = 0; i < _count; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
        }

        #endregion

        #region Max

        public int Max()
        {
            int max = 0;

            for (int i = 0; i < _count; i++)
            {
                if (_items[i] > max)
                {
                    max = _items[i];
                }
            }

            return max;
        }

        #endregion

        #region Reverse

        public void Reverse()
        {
            int[] temps = new int[_count];
 
            for (int i = 0; i < _count; i++) {
                temps[_count - 1 - i] = _items[i];
            }
 
            for (int i = 0; i < _count; i++) {
                _items[i] = temps[i];
            }
        }

        #endregion
        

        #region Print

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Debug.Log(_items[i]);
            }
        }

        #endregion
    }
}
