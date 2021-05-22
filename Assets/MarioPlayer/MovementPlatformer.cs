using UnityEngine;

public class MovementPlatformer : MonoBehaviour
{

    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;
    public KeyCode UpKey = KeyCode.W;

    public float Speed = 1;
    public float JumpSpeed = 3;

    public Vector3 StartpointPosition;

    private bool isOnGround;

    void Start()
    {
        StartpointPosition = transform.position;
        isOnGround = false;
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

        if (Input.GetKeyDown(UpKey) && isOnGround == true)
        {
            //MAKE JUMP
            Debug.Log("jump");
            //GetComponent<Rigidbody>().velocity = Vector3.up * JumpSpeed;
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);

            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isOnGround = true;
        }
    }
}