﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RItem : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TinyAudio.PlaySE(TinyAudio.SE.AppleAttack);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "kabe")
        {
            Destroy(gameObject);
        }
    }
}
