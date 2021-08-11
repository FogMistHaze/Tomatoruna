using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_Select);
        }
        if (Input.GetMouseButtonDown(1))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_Startup);
        }
        if (Input.GetMouseButtonDown(2))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Decision);
        }
        if (Input.GetMouseButtonDown(3))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Cancel);
        }
        if (Input.GetMouseButtonDown(4))
        {
            TinyAudio.PlaySE(TinyAudio.SE.TomatoAttack);
        }
        if (Input.GetMouseButtonDown(5))
        {
            TinyAudio.PlaySE(TinyAudio.SE.CoinAttack);
        }
    }
}
