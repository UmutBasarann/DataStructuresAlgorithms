using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Scripts.ExtendedArray;
using Array = DSA.Scripts.ExtendedArray.Array;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        Array items = new Array(3);
        items.Insert(10);
        items.Insert(20);
        items.Insert(30);
        items.Insert(10);
        int[] commons = items.Intersect();
        for (int i = 0; i < commons.Length; i++)
        {
            Debug.Log(commons[i]);
        }
    }

    #endregion
}
