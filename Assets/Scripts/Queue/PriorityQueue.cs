using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSA.Scripts.Queue
{
    public class PriorityQueue
    {
        #region Fields

        private int[] _queue;
        private int _count = 0;

        #endregion

        #region Constructor

        public PriorityQueue(int capacity)
        {
            _queue = new int[capacity];
        }

        #endregion

        #region Add

        public void Add(int item)
        {
            if (IsFull())
            {
                throw new Exception("Illegal State Exception");
            }

            int i = ShiftItemsToAdd(item);

            _queue[i] = item;
            _count++;
        }

        #endregion

        #region Remove

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Illegal State Exception");
            }
            
            return _queue[--_count];
        }

        #endregion

        #region IsEmpty

        public bool IsEmpty()
        {
            return _count == 0;
        }

        #endregion

        #region IsFull

        public bool IsFull()
        {
            return _count == _queue.Length;
        }

        #endregion
        
        #region ToString

        public override string ToString()
        {
            int[] copies = new int[_count];
            
            System.Array.Copy(_queue, copies, _count);
            
            return string.Join(",", copies);
        }

        #endregion

        #region ShiftItems

        private int ShiftItemsToAdd(int item)
        {
            int i;
            
            for (i = _count - 1; i >= 0; i--)
            {
                if (_queue[i] > item)
                {
                    _queue[i + 1] = _queue[i];
                }
                else
                {
                    break;
                }
            }

            return i + 1;
        }

        #endregion
    }
}
