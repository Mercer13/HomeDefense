using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.6f);
        gameObject.SetActive(false);
    }
}
