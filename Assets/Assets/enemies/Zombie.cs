using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int MoveSpeed; //Movimiento del enemigo
    public float MaxDisJugador; //La distancia Maxima en la que localiza al enemigo
    public float MinDistJugador; //Minima distancia en la que localiza al anemigo
    public Transform Player; 


    // Start is called before the first frame update
    void Start()
    {
        Vector2 EnemyPos = transform.position;
        Vector2 PlayerPos = Player.position;
        float distancia =
            Vector2.Distance(EnemyPos, PlayerPos);

        if (distancia >= MinDistJugador && distancia <= MaxDisJugador)
        {
            Vector2 targetPos = new Vector2(Player.position.x, this.transform.position.y);
            transform.LookAt(targetPos);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
