using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunctions : MonoBehaviour
{
    public GameObject cube;
    private void Awake()
    {
        Debug.Log("Awake");
        cube.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");  
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");    
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void OnApplicationPause(bool pause)
    {
        Debug.Log("Application Pause");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("Application Quit");
    }
}
