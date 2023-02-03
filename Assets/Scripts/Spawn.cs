using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    Missile[] missiles;

    public Transform SpawnPos;
    //public Transform EndPos;
    public GameObject Missile;
    public float TimeSpawn;
    public int CountMissile;
    public string nextLevelName;

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        // Instantiate(Missile, SpawnPos.position, Quaternion.identity);
        Instantiate(Missile, SpawnPos.position, SpawnPos.rotation);
        missiles = FindObjectsOfType<Missile>();
        yield return new WaitForSeconds(TimeSpawn);

        if (CountMissile != 1)
        {
            CountMissile--;
            Start();
        }
        else
            MissileAreDead();
    }

    bool MissileAreDead()
    {
        foreach (var missile in missiles)
        {
            if (missile.gameObject.activeSelf)
            {
                return false;
            }
        }

        return true;
    }

    void Update()
    {
        if (MissileAreDead())
        {
            GoNextLevel();
        }
    }

    void GoNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
