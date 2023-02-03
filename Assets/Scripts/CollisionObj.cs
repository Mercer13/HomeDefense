using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObj : MonoBehaviour
{
    private void OnColisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "House")
        {
            Debug.Log("112211");
        }
    }
}
