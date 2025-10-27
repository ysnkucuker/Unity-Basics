using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentler : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpPower;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpPower * Time.deltaTime);
    }
}
