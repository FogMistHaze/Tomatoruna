using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
}

//クリアしたりゲームオーバーになってから戻ると時間が止まってるので追加
//これがあるならGameManagerの方にはいらなかった気がする