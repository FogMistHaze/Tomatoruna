﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float speedmin = 1f;
    [SerializeField]
    float speedmax = 5f;

    float spped;
    Rigidbody rb;

    private void Awake()
    {
        speed = Random.Range(speedMin, speedMax);
        rb = GetComponent<Rigidbody>();
        SetRandowVelocity();
    }

    void SetRandowVelocity()
    {
        var th = Random.Range(0, 360);
        var dir = new Vector3(Mathf.Cos(th * MathfDeg2Rad), Mathf.Sin(th * Mathf.Deg2Rad), 0);
        rb.velocity = dir * speed;
    }

    void FixedUpdate()
    {
        if(Mathf.Approximately(rb.velocity.magnitude,0f))
        {
            SetRandowVelocity();
        }
        rb.velocity = rb.velocity.normalized * speedmin;
    }
}