using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventsStar : MonoBehaviour
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
