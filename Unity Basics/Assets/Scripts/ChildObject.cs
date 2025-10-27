using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObject : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<ParentObject>().DebugChildObject("Child Object.");
    }
    public void ParentDebug(string content)
    {
        Debug.Log(content);
    }
}
