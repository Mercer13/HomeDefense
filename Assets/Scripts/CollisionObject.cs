using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionObject : MonoBehaviour
{
    private int missileCount = 1;
    public GameObject gameOverScene;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("MissileTag"))
        {
            missileCount++;
            Debug.Log("Alarm! " + missileCount);
        }    
    }

    void Start()
    {
        gameOverScene.SetActive (false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        //Debug.Log("Update is worling... ");
        if (missileCount > 2)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverScene.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Game Over!");
    }

    public void LoadLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
