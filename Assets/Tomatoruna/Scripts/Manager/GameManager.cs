using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using NCMB;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText = default;

    [SerializeField]
    TextMeshProUGUI highScoreText = default;

    static int score;
    static int highScore;

    const int ScoreMax = 99999;

    static bool clear;
    static bool gameover;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        Instance = this;

        score = 0;

        clear = false;
        gameover = false;
    }

    void Start()
    {
        UpdateHighScoreText();
        Time.timeScale = 1;       
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = $"{score:00000}";
    }

    void UpdateHighScoreText()
    {
        if (highScoreText != null)
            highScoreText.text = $"はいすこあ:{highScore}";
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
        if (clear) return;

        clear = true;

        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        Time.timeScale = 0;

        CheckHighScore();
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(highScore);
    }

    public static void ToGameover()
    {
        if (clear || gameover) return;

        gameover = true;
        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }
}
