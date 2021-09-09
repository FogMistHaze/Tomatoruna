using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSesei : MonoBehaviour
{
    public GameObject itemPrefab;

    float time = 0.5f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.time)
        {
            this.delta = 0;
        
            GameObject item = Instantiate(itemPrefab) as GameObject;
           
            int px = Random.Range(-400, 400);
            int py = Random.Range(400, 400);
            int pz = Random.Range(-105, -105);
            
            item.transform.position = new Vector3(px, py, pz);
            
        }
    }
}
