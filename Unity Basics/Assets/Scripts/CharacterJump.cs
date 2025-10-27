using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody rb;

    public void JumpAction(Vector3 direction, float jumpPower)
    {
        rb.AddForce(direction* jumpPower * Time.deltaTime);
    }

  
}
