using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventCheckpoint : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

}