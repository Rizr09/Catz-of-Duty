using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerVariableHeight : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float fallTime = 0.1f; // Adjust the fall time

    public bool isGrounded;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Adjust the fall time using physics
        if (!isGrounded)
        {
            rb.velocity += Physics.gravity * fallTime * Time.deltaTime;
        }
    }
}
