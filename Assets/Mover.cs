using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float x = 0.00f;
    [SerializeField] float y = 0.00f;
    [SerializeField] float z = 0.01f;
    float min = 0;
    float max = 3;
    bool away = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(away == true)
        {
            min += z;
            if(min >= max)
            {
                away = false;
                z = -z;
            }
        }
        else
        {
            if(min >= 0)
            {
                min += z;
            }
            else
            {
                z = 0;
            }
        }
        transform.Translate(x, y, z); // move the object 0.01 unit per frame in the y direction
    }
}
