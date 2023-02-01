using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    Pig[] pigs;
    public string nextLevelName;

    private void OnEnable()
    {
        pigs = FindObjectsOfType<Pig>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PigsAreDead())
        {
            GoNextLevel();
        }
    }

    bool PigsAreDead()
    {
        foreach(var pig in pigs){
            if(pig.gameObject.activeSelf)
            {
                return false;
            }
        }

        return true;
    }

    void GoNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
