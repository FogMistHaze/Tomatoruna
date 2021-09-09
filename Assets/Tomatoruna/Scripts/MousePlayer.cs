using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePlayer : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private float moveSpeed = 5.0f;

    float cameraDistance = 0;
    Rigidbody rb = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        cameraDistance = Vector3.Distance(Camera.main.transform.position, transform.position);
    }

    void Update()
    {
        velocity = Vector3.zero;
        //if (Input.GetKey(KeyCode.W))
        //    velocity.y += 1;
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;
        //if (Input.GetKey(KeyCode.S))
        //    velocity.y -= 1;
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;

        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        if (velocity.magnitude > 0)
            transform.position += velocity;
    }

    /*
    void Update()
    {
        var mp = Input.mousePosition;
        mp.z = cameraDistance;
        var wp = Camera.main.ScreenToWorldPoint(mp);
        var v = (wp - transform.position) / Time.fixedDeltaTime;
        rb.velocity = v;
    }
    */
}
