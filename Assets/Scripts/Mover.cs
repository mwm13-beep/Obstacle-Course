using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Player movement speed
    [SerializeField] float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        //Grabs the input from the keyboard
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //Moves the object based on the input
        transform.Translate(x, 0, z);
    }
    
}
