using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionObject : MonoBehaviour
{
    private int missileCount;
    [SerializeField] private int health;
    public GameObject gameOverScene;
    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite aliveHeart;
    [SerializeField] private Sprite deadHeart;

    private void Awake()
    {
        missileCount = 3;
        health = missileCount;

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("MissileTag"))
        {
            missileCount--;
            Debug.Log("Alarm! " + missileCount);
            /*if(missileCount > 1)
            {
                lamp1.color = Color.red;
            }
            else (missileCount > 1)*/
        }
        
    }

    void Start()
    {
        Awake();
        gameOverScene.SetActive (false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        //Debug.Log("Update is worling... ");
        if (missileCount == 0)
        {
            GameOver();
        }

        if (health > missileCount)
            health = missileCount;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = aliveHeart;
            else
                hearts[i].sprite = deadHeart;

            if(i < missileCount)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
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
