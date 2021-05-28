using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent OnPlayerDie;
    
    private MovementPlatformer movementScriptOfMario;

    void Start()
    {
        movementScriptOfMario = GetComponent<MovementPlatformer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // CHECK POINT: 
        // *** if mario hit checkpoint, save position of checkpoint in mario next starting position.
        if (other.tag == "Checkpoint")
        {
            movementScriptOfMario.StartpointPosition = other.gameObject.transform.position;
            //GetComponent<MovementPlatformer>().StartpointPosition = other.gameObject.transform.position;

            /*
            startpointPosition = Position of the checkpoint;

            other.gameObject == checkpoint
            other.gameObject.transform.position == Position of the checkpoint

            this == player

*/          
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
            if (this.tag == "Mario")
            {
                //Destroy(this.gameObject);

                OnPlayerDie.Invoke();

                //transform.position = movementScriptOfMario.StartpointPosition;
            }

            if (this.tag == "MarioMushroom")
            {
                transform.localScale = new Vector3(1, 1, 1);
                this.tag = "Mario";
            }
        }
    }
}