using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody rb;
    
    void Start()
    {
        // Instantiate variables
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal");
        move.z = Input.GetAxisRaw("Vertical");
        rb.velocity = speed * 200 * Time.deltaTime * move;
    }
    
}
