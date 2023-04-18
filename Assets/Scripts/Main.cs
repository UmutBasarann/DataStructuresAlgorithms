using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        
        ReverseQueue(queue);

        int[] queueArray = queue.ToArray();

        foreach (int item in queueArray)
        {
            Debug.Log(item);
        }
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
