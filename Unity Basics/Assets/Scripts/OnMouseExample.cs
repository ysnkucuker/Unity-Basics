using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseExample : MonoBehaviour
{
    private bool isActive = false;

    private void Update()
    {
        if (isActive)
            Debug.Log("Actvie");
    }
    private void OnMouseDown()
    {
        isActive = true;
    }
    private void OnMouseUp()
    {
        isActive = false;
    }

    private void OnMouseDrag()
    {
        Debug.Log("On Mouse Drag");
    }

    private void OnMouseExit()
    {
        Debug.Log("On Mouse Exit");
    }
}
