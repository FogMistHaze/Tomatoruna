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
}
