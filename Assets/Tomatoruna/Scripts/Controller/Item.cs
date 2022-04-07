using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Item : MonoBehaviour
{
    public int po;
    public float sp = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameManager.AddPoint(po);
            TinyAudio.PlaySE(TinyAudio.SE.CoinAttack);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * sp, 0);

        if (transform.position.y <= -3 || transform.position.y >= 20) 
        {
            Destroy(gameObject);
        }
    }
    
}
