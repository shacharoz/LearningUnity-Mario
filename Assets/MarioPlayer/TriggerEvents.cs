using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // CHECK POINT: 
        // *** if mario hit checkpoint, save position of checkpoint in mario next starting position.
        if (other.tag == "Checkpoint")
        {
            this.GetComponent<MovementPlatformer>().StartpointPosition = other.GetComponent<Transform>().position;
        }

        // MUSHROOM: 
        // *** if mario hit mushroom, double the size of mario.
        if (other.tag == "Mushroom")
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
    }
}