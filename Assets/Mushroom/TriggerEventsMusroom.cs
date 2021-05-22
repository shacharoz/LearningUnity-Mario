using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventsMusroom : MonoBehaviour
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "MarioStar" || other.tag == "MarioMushroom")
        {
            //do something
            Destroy(this.gameObject);
        }
    }

}