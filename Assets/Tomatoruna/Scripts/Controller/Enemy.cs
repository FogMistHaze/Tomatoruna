using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float sp = 5;
    public GameObject effect = null;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            TinyAudio.StopBGM();
            GameManager.ToGameover();
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
