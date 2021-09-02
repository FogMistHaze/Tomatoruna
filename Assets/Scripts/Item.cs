﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            //GameManager.Instance.AddPoint(100);
            TinyAudio.PlaySE(TinyAudio.SE.CoinAttack);
            Destroy(gameObject); 
        }

        if (collision.collider.CompareTag("kabe"))
        {
            Destroy(gameObject);
        }
    }
}
