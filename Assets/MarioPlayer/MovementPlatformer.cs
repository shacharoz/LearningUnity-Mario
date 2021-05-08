using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatformer : MonoBehaviour
{

    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;
    public KeyCode UpKey = KeyCode.W;

    public float Speed = 1;

    public Vector3 StartpointPosition;


    void Start()
    {
        StartpointPosition = transform.position;
    }

    
    void Update()
    {
        if (Input.GetKey(LeftKey))
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }

        if (Input.GetKey(RightKey))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }

        if (Input.GetKeyDown(UpKey))
        {
            //MAKE JUMP
            Debug.Log("jump");
        }

    }
}