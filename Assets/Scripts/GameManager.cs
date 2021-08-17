#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshPro scoreText = default;
    [SerializeField]
    TextMeshPro timeText = default;

    static bool clear;
    static bool gameover;
    static int score;
    static float time;
    const float StartTime = 10f;
    const int ScoreMax = 99999;

    void Awak()
    {
        Instance = this;

        score = 0;
        time = StartTime;

        clear = false;
        gameover = false;
        ItemGet.ClearCount();
    }

    void UpdateScareText()
    {
        scoreText.text = $"{score:00000}";
    }

    public static void ToClear()
    {
        if (clear || gameover) return;

        clear = true;
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    public static void ToGameover()
    {
        if (clear || gameover) return;

        gameover = true;
        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    public static GameManager Instance { get; private set; }

    public static void AddPoint(int point)
    {
        score += point;

        score = Mathf.Min(score, ScoreMax);
        Instance.UpdateScoreText();
    }

    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Decision);
    }

    // Update is called once per frame
    void Update()
    {
#if DEBUG_KEY
        if(Input.GetKeyDown(KeyCode.O))
        {
            TinyAudio.BGM bgm = TinyAudio.BGM.Gameover;
            SceneManager.LoadScene("Gameover");
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            TinyAudio.BGM bgm = TinyAudio.BGM.Clear;
            SceneManager.LoadScene("Clear");
        }
#endif
    }

    void FixedUpdate()
    {
        time -= time.fixedDeltaTime;
        if(time<=0)
        {
            time = 0;
            ToGameover();
        }
        UpdateTimeText;
    }
}
