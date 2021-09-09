using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
            Time.timeScale = 0;
            //GameManager.ToGameover();
        }
    }


}
