#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static bool clear;
    static bool gameover;

    void Awak()
    {
        ItemGet.ClearCount();
        clear = false;
        gameover = false;    
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
}
