using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DSA.Scripts.Stack
{
    public class StringReverser
    {
        #region Fields

        private Stack<char> _stack = new Stack<char>();

        #endregion

        #region Reverse

        public string Reverse(string input)
        {
            if (input is null)
            {
                throw new ArgumentException("Illegal Argument Exception");
            }
            
            foreach (char character in input)
            {
                _stack.Push(character);
            }

            StringBuilder builder = new StringBuilder();
            while (_stack.Any())
            {
                builder.Append(_stack.Pop());
            }

            return builder.ToString();
        }

        #endregion
    }
}
