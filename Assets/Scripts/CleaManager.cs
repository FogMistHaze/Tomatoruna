using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.StopBGM();
        TinyAudio.PlayBGM(TinyAudio.BGM.Clear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
