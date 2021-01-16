﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    public float thrust = 9.81f;
    public Rigidbody rb;

    public void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust);
    }
}
