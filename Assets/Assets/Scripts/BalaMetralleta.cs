using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMetralleta : MonoBehaviour
{

    [Header("Proyectil Conf ")]
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float projectileSpeed = 20f;

    private bool isShooting = false;
    private float nextFireTime = 0f; //Este se va a calcular

    [Header("Wepon caracteristics ")]

    public int WPNDMGPRIM;
    public int WPNDMGSECN;

    public Vector3 direction;
    public GameObject ACTNPoint;

    public int Attacktimes;
    public float attackTMOUT;

    public float MouseACT1CLDWN;
    public GameObject MouseACT1SPRT;
    public float MouseACT1SPD;

    public float MouseACT2CLDWN;
    public GameObject MouseACT2SPRT;
    public float MouseACT2SPD;


    void FixedUpdate()
    {
        // El botón izquierdo del mouse está presionado
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            // Metodo de disparo de proyectil metralleta
            ShootProjectile();

            // Tiempo para el próximo disparo
            nextFireTime = Time.time + MouseACT1CLDWN;
            
        }
    }

    void ShootProjectile()
    {
        // Instanciar el proyectil en la posición y rotación del punto de disparo
        GameObject projectile = Instantiate(MouseACT1SPRT, ACTNPoint.transform.position, ACTNPoint.transform.rotation);

        // Agregar fuerza al proyectil para que se mueva
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = ACTNPoint.transform.right * MouseACT1SPD;
        }
        else
        {
            Debug.LogError("ACTNPoint no ha sido asignado en el Inspector.");
        }
    }

}
