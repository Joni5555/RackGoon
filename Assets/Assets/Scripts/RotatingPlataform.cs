using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlataform : MonoBehaviour
{
    private float rotZ;
    private float RotationSpeed = 0;
    public float Speed; 
    private float StopTimer = 0;
    public float Timer;


    private bool isRotating;

    private void Start()
    {
        isRotating = true;
        RotationSpeed = Speed;
        StopTimer = Timer;
    }

    void Update()
    {
        rotZ += Time.deltaTime * RotationSpeed;
        transform.rotation = Quaternion.Euler(0,0, rotZ);
        
        StopTimer -= Time.deltaTime;
        
        if (isRotating)
        {
            if (transform.rotation.z <= 0)
            {
                isRotating = false;
                RotationSpeed = 0;
                StopTimer = Timer;
            }   
        }
        else
        {
            if (StopTimer <= 0)
            {
                RotationSpeed = Speed;
            }
            if (transform.rotation.z >= 0)
            {
                isRotating = true;
            }
        }
    }
}
