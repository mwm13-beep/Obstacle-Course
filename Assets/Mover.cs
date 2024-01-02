using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Grabs the input from the keyboard
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Moves the object based on the input
        transform.Translate(x, 0, z); 
    }
}
