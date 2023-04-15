using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Scripts.Stack
{
    public class BalancedString
    {
        #region Fields

        private Stack<char> _stack = new Stack<char>();
        private readonly ArrayList _leftBrackets = new ArrayList
        {
            '(',
            '<',
            '[',
            '{'
        };
        
        private readonly ArrayList _rightBrackets = new ArrayList
        {
            ')',
            '>',
            ']',
            '}'
        };

        #endregion
        
        #region IsBalanced

        public bool IsBalanced(string input)
        {
            foreach (char character in input)
            {
                if (IsLeftBracket(character))
                {
                    _stack.Push(character);
                }

                if (IsRightBracket(character))
                {
                    if (_stack.Count == 0)
                    {
                        return false;
                    }

                    char top = _stack.Pop();
                    if (!IsMatchingBracket(character, top))
                    {
                        return false;
                    }
                }
            }

            return _stack.Count == 0;
        }

        #endregion

        #region IsLeftBracket

        private bool IsLeftBracket(char character)
        {
            return _leftBrackets.Contains(character);
        }

        #endregion

        #region IsRightBracket

        private bool IsRightBracket(char character)
        {
            return _rightBrackets.Contains(character);
        }

        #endregion

        #region IsMatchingBracket

        private bool IsMatchingBracket(char left, char right)
        {
            return _leftBrackets.IndexOf(left) == _rightBrackets.IndexOf(right);
        }

        #endregion
    }
}
