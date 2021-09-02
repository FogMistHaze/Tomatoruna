using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoSeisei : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    float time = 1f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.time)
        {
            this.delta = 0;

            GameObject enemy = Instantiate(enemyPrefab) as GameObject;
            
            int px = Random.Range(-400, 400);
            int py = Random.Range(500, 500);
            int pz = Random.Range(-40, -40);

            enemy.transform.position = new Vector3(px, py, pz);
            
        }
    }
}
