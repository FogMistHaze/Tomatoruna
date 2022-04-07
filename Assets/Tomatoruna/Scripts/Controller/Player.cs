using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float sp = 3f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector3 Idou = new Vector3(x, 0, 0);
        rb.velocity = Idou * sp;

        //移動制限
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f),Mathf.Clamp(transform.position.y, 0f, 0f),Mathf.Clamp(transform.position.z, 0f, 0f));
    }
}
