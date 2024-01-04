using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided with this object has the tag "Player"
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
