#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText = default;

    [SerializeField]
    TextMeshProUGUI timeText = default;

    [SerializeField]
    TextMeshProUGUI highScoreText = default;

    static bool clear;
    static bool gameover;

    static int score;
    static float time;
    static int highScore;

    const float StartTime = 30f;

    const int ScoreMax = 99999;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        
        Instance = this;

        score = 0;
        time = StartTime;

        clear = false;
        gameover = false;
    }
    
    void UpdateScoreText()
    {
        if (scoreText != null) 
            scoreText.text = $"{score:00000}";
    }
    
    void UpdateTimeText()
    {
        if (timeText != null) 
            timeText.text = $"{time:00}";
    }
    
    void UpdateHighScoreText()
    {
        if (highScoreText != null) 
            highScoreText.text = $"はいすこあ:{highScore:00000}";
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
    
    public static void AddPoint(int point)
    {
        score += point;

        score = Mathf.Min(score, ScoreMax);

        Instance.UpdateScoreText();
    }

    public static void CheckHighScore()
    {
        if(score>highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
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
