using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float MoveSpeed; // Movimiento del enemigo
    public float MaxDisJugador; // La distancia Maxima en la que localiza al enemigo
    public Transform Player;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 EnemyPos = transform.position;
        Vector2 PlayerPos = Player.position;
        float distancia = Vector2.Distance(EnemyPos, PlayerPos);

        if (distancia <= MaxDisJugador)
        {
            Vector2 direction = (PlayerPos - EnemyPos).normalized; // Normaliza la dirección
            rb.MovePosition(rb.position + direction * MoveSpeed * Time.deltaTime); // Mueve el enemigo usando Rigidbody2D

            // Rotación hacia el jugador (opcional)
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle; // Cambia la rotación del Rigidbody2D
        }
    }
}

