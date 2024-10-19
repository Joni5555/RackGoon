using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlataform : MonoBehaviour
{
    private float rotZ;
    public float RotationSpeed;
    public float Timer = 4.0f;


    private bool isRotating;

    private void Start()
    {
        isRotating = true;
        RotationSpeed = 100;
        
    }

    void Update()
    {
        rotZ += Time.deltaTime * RotationSpeed;
        transform.rotation = Quaternion.Euler(0,0, rotZ);
        
        Timer -= Time.deltaTime;
        
        if (isRotating)
        {
            if (transform.rotation.z <= 0)
            {
                isRotating = false;
                RotationSpeed = 0;
                Timer = 4.0f;
            }   
        }
        else
        {
            if (Timer <= 0)
            {
                RotationSpeed = 100;
            }
            if (transform.rotation.z >= 0)
            {
                isRotating = true;
            }
        }
    }
}
