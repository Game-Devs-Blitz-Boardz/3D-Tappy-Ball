using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector3.up * jumpForce;
        }
    }
}
