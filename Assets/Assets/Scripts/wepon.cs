using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    public GameObject actionpoint;
    public GameObject Bala;


    void Update()
    {
        // El botón izquierdo del mouse está presionado
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
