using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    public GameObject actionpoint;
    public GameObject Bala;


    void Update()
    {
        // El bot�n izquierdo del mouse est� presionado
        if (Input.GetMouseButtonDown(0))
        {
            // Metodo de disparo de proyectil metralleta
            ShootProjectile();

        }
    }

    void ShootProjectile()
    {
        Debug.Log("Babb!!!!");
        GameObject projectile = Instantiate(Bala, actionpoint.transform.position, actionpoint.transform.rotation);
    }

}
