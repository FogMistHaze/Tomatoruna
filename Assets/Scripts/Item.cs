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
            
            count--;
            if (count <= 0)
            {
                SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
                Time.timeScale = 0;
            }

            count--;
            if (count <= 0)
            {
                GameManager.ToClear();
            }
        }
    }

    public Item():base()
    {
        count++;
    }

    /*
    private void Start()
    {
        count++;
        Debug.Log(count);
    }
    */
}
