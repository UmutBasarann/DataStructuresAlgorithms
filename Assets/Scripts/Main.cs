using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DSA.Scripts.Dictionary;
using DSA.Scripts.Hash;
using DSA.Scripts.Queue;
using UnityEngine;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        
    }

    #endregion

    #region ReverseQueue

    private static void ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Any())
        {
            stack.Push(queue.Dequeue());
        }

        while (stack.Any())
        {
            queue.Enqueue(stack.Pop());
        }
    }

    #endregion
}
