using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    static int count = 0;

    public static void ClearCount()
    {
        count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject); 
            //クリアチェック
            count--;
            if (count <= 0)
            {
                GameManager.ToClear();
            }
        }

        if (collision.gameObject.tag == "kabe")
        {
            Destroy(gameObject);
        }
    }

    public Item():base()
    {
        count++;
    }

    private void Start()
    {
        count++;
        Debug.Log(count);
    }
}
