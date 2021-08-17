using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    static int count = 0;

    public static void ClearCount()
    {
        count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.AddPoint(100);

        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        count--;
        if(count<=0)
        {
            GameManager.ToClear();
        }
    }

    public ItemGet():base()
    {
        count++;
    }
}
