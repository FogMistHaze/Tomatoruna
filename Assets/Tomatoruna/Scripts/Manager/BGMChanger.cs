using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMChanger : MonoBehaviour
{
    [Tooltip("鳴らしたいBGM"), SerializeField]
    TinyAudio.BGM bgm = TinyAudio.BGM.Gameover;

    void Start()
    {
        TinyAudio.PlayBGM(bgm);
    }
}
