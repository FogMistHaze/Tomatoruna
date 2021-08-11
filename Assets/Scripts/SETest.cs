using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_Select);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_Startup);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Decision);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Cancel);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            TinyAudio.PlaySE(TinyAudio.SE.TomatoAttack);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TinyAudio.PlaySE(TinyAudio.SE.CoinAttack);
        }
    }
}
