using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    Rigidbody m_Rigidbody;
    public float speed = 20f;
    public float lifeTime = 2f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        // Destruir la bala después de 'lifeTime' segundos para limpiar la escena
        m_Rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
    }
}