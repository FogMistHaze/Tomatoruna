using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText = default;

    [SerializeField]
    TextMeshProUGUI scoreText = default;

    [SerializeField]
    TextMeshProUGUI highScoreText = default;

    static int score;
    static int highScore;

    const int ScoreMax = 99999;

    static bool clear;
    static bool gameover;

    static float time;
    const float StartTime = 30f;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        Instance = this;

        time = StartTime;
        score = 0;

        clear = false;
        gameover = false;
    }

    void UpdateTimeText()
    {
        if (timeText != null)
            timeText.text = $"{time:00}";
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = $"{score:00000}";
    }

    void UpdateHighScoreText()
    {
        if (highScoreText != null)
            highScoreText.text = $"はいすこあ:{highScore:00000}";
    }

    public static void AddPoint(int point)
    {
        score += point;

        score = Mathf.Min(score, ScoreMax);

        Instance.UpdateScoreText();
    }

    public static void CheckHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public static void ToClear()
    {
        if (clear || gameover) return;

        clear = true;

        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        Time.timeScale = 0;

        CheckHighScore();
    }

    public static void ToGameover()
    {
        if (clear || gameover) return;

        gameover = true;

        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }
    
    void Start()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Decision);
        UpdateHighScoreText();
    }

    void FixedUpdate()
    {
        time -= Time.fixedDeltaTime;
        if (time <= 0)
        {
            time = 0;
            ToClear();
        }
        UpdateTimeText();
    }
}
