﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Item")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
