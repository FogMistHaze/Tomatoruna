using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    [Tooltip("切り替えたいシーン名"), SerializeField]
    string nextScene = "";

    bool sceneChanged;

    public void ChangeScene()
    {
        if (sceneChanged) return;

        sceneChanged = true;
        TinyAudio.PlaySE(TinyAudio.SE.Decision);
        SceneManager.LoadScene(nextScene);
    }

    public void SetChangeFalse()
    {
        sceneChanged = false;
    }
}

/*
【シーン遷移のプログラム】
nextSceneに入れた名前のSceneに遷移する
sceneChangedはアニメーションを待っている間は遷移しないようにする為に実装
*/