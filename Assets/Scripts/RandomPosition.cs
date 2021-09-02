using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    Bounds spawnBounds;

    const float SpawnRangeX = 0.25f;
    const float SpawnRangeY = 0.2f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(spawnBounds.center, spawnBounds.size);
    }

    void Awake()
    {
        var pos = transform.position;
        pos.x = Random.Range(spawnBounds.min.x, spawnBounds.max.y);
        pos.y = Random.Range(spawnBounds.min.y, spawnBounds.max.y);
        transform.position = pos;
    }

    /*
    public GameObject enemyPrefab;
    public GameObject itemPrefab;
    public GameObject ritemPrefab;
    

    float time = 1f;
    float delta = 0;

    void Start()
    {
        //interval = GetRandomTime();
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.time)
        {
            this.delta = 0;
            GameObject enemy = Instantiate(enemyPrefab) as GameObject;
            GameObject item = Instantiate(itemPrefab) as GameObject;
            GameObject ritem = Instantiate(ritemPrefab) as GameObject;
            int px = Random.Range(-1000, -200);
            int py = Random.Range(520, 520);
            int pz = Random.Range(-110, -110);
            enemy.transform.position = new Vector3(px, py, pz);
            item.transform.position = new Vector3(px, py, pz);
            ritem.transform.position = new Vector3(px, py, pz);
        }
    }
    */
}
