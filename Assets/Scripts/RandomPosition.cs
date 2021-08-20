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
        pos.x = Random.Range(spawnBounds.min.x, spawnBounds.max.x);
        pos.y = Random.Range(spawnBounds.min.y, spawnBounds.max.y);
        transform.position = pos;
        /*
        for (var i = 0; i < 100; i++)
        {
            var xn = xpos / xDist;
            var yn = ypos / yDist;

            if ((xn < SpawnRangeX)
                || (xn > 1f - SpawnRangeX)
                || (yn < SpawnRangeY)
                || (yn > (1f - SpawnRangeY)))
            {
                break;
            }

            xpos = Random.Range(-minRange.x, xDist - maxRange.x);
            ypos = Random.Range(-minRange.y, yDist - maxRange.y);
        }
        */
    }

    
}
