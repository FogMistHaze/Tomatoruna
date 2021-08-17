using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomatougo : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.up;
        rb.velocity = Vector3.up * 5f; ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        rb.velocity = move.normalized * 5f;
    }
}
