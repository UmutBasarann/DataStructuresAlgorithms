using System;
using System.Collections.Generic;

namespace DSA.Scripts.Stack
{
    public class StackQueue
    {
        #region Fields

        private Stack<int> _enqueueStack = new Stack<int>();
        private Stack<int> _dequeueStack = new Stack<int>();

        #endregion

        #region Enqueue

        public void Enqueue(int item)
        {
            _enqueueStack.Push(item);
        }

        #endregion

        #region Dequeue

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Illegal State Exception");
            }
            
            CopyEnqueueToDequeue();

            return _dequeueStack.Pop();
        }

        #endregion

        #region Peek

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Illegal State Exception");
            }
            
            CopyEnqueueToDequeue();

            return _dequeueStack.Peek();
        }

        #endregion

        #region IsEmpty

        public bool IsEmpty()
        {
            return _enqueueStack.Count == 0 && _dequeueStack.Count == 0;
        }

        #endregion

        #region CopyEnqueueToDequeue

        private void CopyEnqueueToDequeue()
        {
            if (_dequeueStack.Count == 0)
            {
                while (_enqueueStack.Count != 0)
                {
                    _dequeueStack.Push(_enqueueStack.Pop());
                }
            }
        }

        #endregion
    }
}
