using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    public float speed = 10f;
    public float returnTime = 2f;
    public Transform player;
    private Vector3 launchDirection;
    private bool returning = false;
    private float returnTimer = 0f;

    void Start()
    {
        launchDirection = transform.forward;
    }

    void Update()
    {
        if (returning)
        {
            ReturnToPlayer();
        }
        else
            transform.position += launchDirection * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, player.position) > 20f)
        {
            returning = true;
            returnTimer = 0f;
        }
    }

    void ReturnToPlayer()
    {
        returnTimer += Time.deltaTime;
        float t = returnTimer / returnTime;
        transform.position = Vector3.Lerp(transform.position, player.position, t);

        if (t >=  1f)
        {
        Destroy(gameObject);
        }
    }
}