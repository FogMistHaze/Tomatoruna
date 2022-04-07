using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartCount : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI StartCountDown = default;

    public GameObject timers;

    public float Count = 4f;
    private int stint;

    public bool Go = false;

    void Update()
    {
        if (Count > 0)
        {
            Count -= Time.deltaTime;
            stint = (int)Count;
            StartCountDown.text = $"{stint}";

            if (Count <= 1)
            {
                StartCountDown.text = $"すたーと";
                Go = true;
            }
            if (Count <= 0)
            {
                timers.SetActive(false);
            }
        }

    }
}
