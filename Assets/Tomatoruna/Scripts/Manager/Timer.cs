using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText = default;

    StartCount startCount;

    static float time;
    const float StartTime = 30f;

    void Awake()
    {
        time = StartTime;
    }

    void Start()
    {
        startCount = GetComponent<StartCount>();
    }

    void UpdateTimeText()
    {
        if (timeText != null)
            timeText.text = $"{time:00}";
    }

    void FixedUpdate()
    {
        if (startCount.Go == true)
        {
            time -= Time.fixedDeltaTime;
            if (time <= 0)
            {
                time = 0;
                GameManager.ToClear();
            }
            UpdateTimeText();
        }
    }
}

/*
【ゲームのカウント】
30秒を-1ずつカウントする。テキストに反映
ゲーム開始のカウントが終わってから実行
*/