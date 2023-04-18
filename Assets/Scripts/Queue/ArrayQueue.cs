using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSA.Scripts.Queue
{
    public class ArrayQueue
    {
        #region Fields

        private int[] _queue;
        private int _rear = 0;
        private int _front = 0;
        private int _count = 0;

        #endregion

        #region Constructor

        public ArrayQueue(int capacity)
        {
            _queue = new int[capacity];
        }

        #endregion

        #region Enqueue

        public void Enqueue(int item)
        {
            if (_count == _queue.Length)
            {
                throw new Exception("Queue Full Exception");
            }

            _queue[_rear] = item;
            _rear = (_rear + 1) % _queue.Length;
            _count++;
        }

        #endregion

        #region Dequeue

        public int Dequeue()
        {
            int item = _queue[_front];
            _queue[_front] = 0;
            _front = (_front + 1) % _queue.Length;
            _count--;
            return item;
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
    }
}
