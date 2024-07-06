using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    void FixedUpdate()
    {
        
        rb.AddForce(new Vector3(0f, 0f, -2f));
        //rb.velocity = new Vector3(0,0,-1);
        
    }
}
