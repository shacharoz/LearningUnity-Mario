using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{

    public UnityEvent OnPlayerDie;


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
            this.tag = "MarioMushroom";
        }


        // STAR: 
        // *** if mario hit star, become invincible and yellow.
        if (other.tag == "Star")
        {
            GetComponent<MeshRenderer>().material.color = Color.yellow; //later with animation we would like to switch color fast
            this.tag = "MarioStar";
        }

        // ENEMY: 
        // *** if mario hit enemy, die.
        if (other.tag == "Enemy")
        {
            if (this.tag == "Player")
            {
                //Destroy(this.gameObject);

                OnPlayerDie.Invoke();
            }

            if (this.tag == "MarioMushroom")
            {
                transform.localScale = new Vector3(1, 1, 1);
                this.tag = "Player";
            }
        }
    }
}