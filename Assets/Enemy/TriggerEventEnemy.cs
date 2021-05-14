using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MarioStar")
        {
            Destroy(this.gameObject);
        }
    }

}
