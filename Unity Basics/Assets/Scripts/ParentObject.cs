using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObject : MonoBehaviour
{
    private void Start()
    {
        for(int i=0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponentInChildren<ChildObject>().ParentDebug("parent test");
        }
        
    }
    public void DebugChildObject(string content)
    {
        Debug.Log(content);
    }
}
