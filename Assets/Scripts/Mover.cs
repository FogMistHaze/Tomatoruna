using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float speedMin = 1f;
    [SerializeField]
    float speedMax = 5f;

    float speed;
    Rigidbody rb;
    
    private void Awake()
    {
        speed = Random.Range(speedMin, speedMax);
        var th = Random.Range(0, 360);
        var dir = new Vector3(Mathf.Cos(th * Mathf.Deg2Rad), Mathf.Sin(th * Mathf.Deg2Rad), 0);
        rb = GetComponent<Rigidbody>();
        rb.Velocity = dir * speed;
    }
    
    void SetRandomVelocity()
    {
        var th = Random.Range(0, 360);
        var dir = new Vector3(Mathf.Cos(th * Mathf.Deg2Rad), Mathf.Sin(th * Mathf.Deg2Rad), 0);
        rb.velocity = dir * speed;
    }

    /*
    void Awake()
    {
        speed = Random.Range(speedMin, speedMax);
        rb = GetComponent<Rigidbody>();
        SetRandomVelocity();
    }
    */

    void FixedUpdate()
    {
        if(Mathf.Approximately(rb.velocity.magnitude,0f))
        {
            SetRandomVelocity();
        }
        rb.velocity = rb.velocity.normalized * speed;
    }
}
