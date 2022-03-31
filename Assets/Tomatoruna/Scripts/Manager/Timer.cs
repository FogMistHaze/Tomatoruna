using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText = default;

    static float time;
    const float StartTime = 30f;

    void Awake()
    {
        time = StartTime;
    }

    void UpdateTimeText()
    {
        if (timeText != null)
            timeText.text = $"{time:00}";
    }

    void FixedUpdate()
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
