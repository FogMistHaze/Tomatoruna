using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seisei : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject rarePrefab;
    public GameObject tomatoPrefab;

    public Transform rangeA;
    public Transform rangeB;

    private float time;

    void Update()
    {
        time += time + Time.deltaTime;

        if (time > 5.0f)
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            Instantiate(tomatoPrefab, new Vector3(x, y, z), tomatoPrefab.transform.rotation);

            time = 0f;
        }
    }
}
