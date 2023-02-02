using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] private float stamina = 5f; // выносливость свиньи
    public float speed;
    public Vector2 dir;

    private void OnCollisionEnter2D(Collision2D collision) // метод для столкновения
    {
        if (collision.relativeVelocity.magnitude > stamina) // если сила удара больше, чем выносливость
        {
           // Destroy(gameObject); // то объект удаляется
           gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * dir * Time.deltaTime, Space.World);
    }
}
