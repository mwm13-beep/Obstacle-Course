using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //cache references and set default values
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the specified number of seconds have passed
        if(Time.time >= waitTime)
        {
            // Turn on gravity and mesh renderer
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
