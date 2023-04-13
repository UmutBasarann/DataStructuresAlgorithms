using UnityEngine;

namespace DSA.Scripts.BigO
{
    public class BigONotation
    {
        #region O(1) Example
    
        private void OofOneExample(int[] numbers)
        {
            // O(1)
            Debug.Log(numbers[0]);
        }
    
        #endregion
    
    
        #region O(n) Example
    
        /// <summary>
        /// if we have separate for loops
        /// based on given length
        /// the complexity of this method
        /// is going to be
        /// O(n + m)
        /// but to simplify we call it
        /// O(n)
        /// which is linear
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="names"></param>
        private void OofNExample(int[] numbers, string[] names)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
    
            
            for (int i = 0; i < names.Length; i++)
            {
                Debug.Log(names[i]);
            }
        }
    
        #endregion
    
    
        #region O(n ^ 2) Example
    
        /// <summary>
        /// if we add another nested for loop
        /// in this case the complexity of this method
        /// is going to be
        /// O(n ^ 3)
        /// which is Quadratic
        /// </summary>
        /// <param name="numbers"></param>
        private void OofNSquaredExample(int[] numbers)
        {
            // O(n ^ 2)
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Debug.Log($"{numbers[i]}, {numbers[j]}");
                }
            }
        }
    
        #endregion
    }
}

