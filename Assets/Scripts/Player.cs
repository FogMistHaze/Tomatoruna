using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    /*
    float cameraDistance = 0;
    Rigidbody rb = null;
    */

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            //SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
            //Time.timeScale = 0;
            GameManager.ToGameover();
        }
    }

    /*
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.up;
        rb.velocity = Vector3.up * 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = rb.velocity;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GeaAxisRaw("Vertical");
        rb.velocity = move.normalized * 5f;
    }
    */
}
