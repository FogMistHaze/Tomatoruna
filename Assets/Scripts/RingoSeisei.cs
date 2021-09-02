using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingoSeisei : MonoBehaviour
{
    public GameObject ritemPrefab;

    float time = 3f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.time)
        {
            this.delta = 0;
            
            GameObject ritem = Instantiate(ritemPrefab) as GameObject;
            
            int px = Random.Range(-400, 400);
            int py = Random.Range(500, 500);
            int pz = Random.Range(-35, -35);
            
            ritem.transform.position = new Vector3(px, py, pz);
        }
    }
}
