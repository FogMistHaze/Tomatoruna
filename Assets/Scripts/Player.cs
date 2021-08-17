using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float cameraDistance = 0;
    Rigidbody rb = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraDistance = Vector3.Distance(Camera.main.transform.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var mp = Input.mousePosition;
        mp.z = cameraDistance;
        var wp = Camera.main.ScreenToWorldPoint(mp);
        var v = (wp - transform.position) / Time.fixedDeltaTime;
        rb.velocity = v;
    }


}
