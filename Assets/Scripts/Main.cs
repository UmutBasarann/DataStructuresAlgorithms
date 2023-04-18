using System.Collections.Generic;
using System.Linq;
using DSA.Scripts.Queue;
using UnityEngine;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        PriorityQueue queue = new PriorityQueue(5);
        queue.Add(5);
        queue.Add(3);
        queue.Add(6);
        queue.Add(1);
        queue.Add(4);
        
        Debug.Log(queue);
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
