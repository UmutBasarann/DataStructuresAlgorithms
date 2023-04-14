using UnityEngine;
using DSA.Scripts.LinkedListExample;

public class Main : MonoBehaviour
{
    #region Awake | Start | Update

    private void Start()
    {
        LinkedList linkedList = new LinkedList();
        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddLast(30);
        linkedList.AddLast(40);
        linkedList.AddLast(50);
    }

    #endregion
}
