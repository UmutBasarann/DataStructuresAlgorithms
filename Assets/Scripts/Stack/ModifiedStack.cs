using System;

namespace DSA.Scripts.Stack
{
    public class ModifiedStack
    {
        #region Fields

        private int[] _stack = new int[5];
        private int _count = 0;

        #endregion

        #region Push

        public void Push(int item)
        {
            if (_count == _stack.Length)
            {
                throw new StackOverflowException();
            }
            
            _stack[_count++] = item;
        }

        #endregion

        #region Pop

        public int Pop()
        {
            if (_count == 0)
            {
                throw new Exception("Illegal State Exception");
            }
            
            return _stack[--_count];
        }

        #endregion

        #region Peek

        public int Peek()
        {
            if (_count == 0)
            {
                throw new Exception("Illegal State Exception");
            }
            
            return _stack[_count - 1];
        }

        #endregion

        #region IsEmpty

        public bool IsEmpty()
        {
            return _count == 0;
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            int[] copies = new int[_count];
            
            System.Array.Copy(_stack, copies, _count);
            
            return string.Join(",", copies);
        }

        #endregion
    }
}
