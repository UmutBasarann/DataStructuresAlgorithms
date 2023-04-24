using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DSA.Scripts.BinarySearchTree;
using DSA.Scripts.Dictionary;
using DSA.Scripts.Hash;
using DSA.Scripts.Queue;
using UnityEngine;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        BinaryTree tree = new BinaryTree();
        tree.Add(7);
        tree.Add(4);
        tree.Add(9);
        tree.Add(1);
        tree.Add(8);
        tree.Add(6);
        tree.Add(10);
        
        Debug.Log(tree.IsBinarySearchTree());
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
