using UnityEngine;
using DSA.Scripts.Array;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        DynamicArray items = new DynamicArray(3);
        items.Insert(10);
        items.Insert(20);
        items.Insert(30);
        items.Insert(10);
    }

    #endregion
}
