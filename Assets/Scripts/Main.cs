using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Scripts.LinkedListExample;
using DSA.Scripts.Stack;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        BalancedString balancedString = new BalancedString();
        bool isBalanced = balancedString.IsBalanced("{as}[dfg](+)<>");
        
        Debug.Log(isBalanced);
    }

    #endregion
}
