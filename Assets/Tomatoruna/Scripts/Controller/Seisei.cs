using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seisei : MonoBehaviour
{
    public GameObject[] Prefabs;
    StartCount startCount;

    public Transform rangeA;
    public Transform rangeB;
    
    private float time;
    private int number;

    void Start()
    {
        time = 1.0f;
        startCount = GetComponent<StartCount>();
    }

    void FixedUpdate()
    {
        if (startCount.Go == true)
        {
            time -= Time.deltaTime;

            if (time <= 0.0f)
            {
                time = 0.5f;
                number = Random.Range(0, Prefabs.Length);

                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                float z = Random.Range(rangeA.position.z, rangeB.position.z);

                Instantiate(Prefabs[number], new Vector3(x, y, z), Quaternion.identity);
            }
        }     
    }
}
