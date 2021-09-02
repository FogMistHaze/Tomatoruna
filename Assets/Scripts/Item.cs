using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    //static int count = 0;

    /*
    public static void ClearCount()
    {
        count = 0;
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            //GameManager.Instance.AddPoint(100);
            Destroy(gameObject); 
        }

        if (collision.collider.CompareTag("kabe"))
        {
            Destroy(gameObject);
        }
    }

    /*
    public Item():base()
    {
        count++;
    }

    private void Start()
    {
        count++;
        Debug.Log(count);
    }
    */
}
