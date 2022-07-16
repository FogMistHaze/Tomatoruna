using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public int po;
    public float sp = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameManager.AddPoint(po);
            TinyAudio.PlaySE(TinyAudio.SE.CoinAttack);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * sp, 0);

        if (transform.position.y <= -3 || transform.position.y >= 20) 
        {
            Destroy(gameObject);
        }
    }
    
}

/*
【コインとリンゴのスクリプト】
プレイヤー(お椀)に触れたら...
スコアに変数poに入力した値を加算する、SEを鳴らす、ゲームオブジェクトを消す

一定の範囲内から出たらゲームオブジェクトを消す
 */