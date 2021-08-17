using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.StopBGM();
        TinyAudio.PlayBGM(TinyAudio.BGM.Gameover);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
