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

    public GameObject enemyPrefab;
    public GameObject itemPrefab;
    public GameObject ritemPrefab;

    public float minTime = 1f;
    public float maxTime = 5f;
    public float xMinPosition = -10f;
    public float xMaxPosition = 10f;
    public float yMinPosition = 0f;
    public float yMaxPosition = 10f;
    public float zMinPosition = 10f;
    public float zMaxPosition = 20f;

    private float interval;

    private float time = 0f;

    void Start()
    {
        interval = GetRandomTime();
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = GetRandomPosition();

            GameObject itme = Instantiate(itemPrefab);
            itme.transform.position = GetRandomPosition();

            GameObject ritem = Instantiate(ritemPrefab);
            ritem.transform.position = GetRandomPosition();

            time = 0f;
            interval = GetRandomTime();
        }
    }

    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        return new Vector3(x, y, z);
    }
}
