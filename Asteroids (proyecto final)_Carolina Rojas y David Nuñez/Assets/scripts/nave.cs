using UnityEditor;
using UnityEngine;

public class nave : MonoBehaviour
{
    Rigidbody2D ship;

    Transform direction;

    public float rtt = 180;
    float maxSpeed = 4.5f;
    public GameObject gun;
    public Transform Aimer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        ship = GetComponent<Rigidbody2D>();
        //rtt = 180;
    
    }
    private void FixedUpdate()
    {
        ship.linearVelocity =
            Vector2.ClampMagnitude(ship.linearVelocity , maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.InputSystem.Keyboard.current.upArrowKey.isPressed)        //MOVIMIENTO
        {
            ship.AddForce(transform.up * 0.1f , ForceMode2D.Impulse);       
        }

        if (UnityEngine.InputSystem.Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(0, 0, rtt * Time.deltaTime);
        }

        if (UnityEngine.InputSystem.Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(0, 0, -rtt * Time.deltaTime);
        }


        if (UnityEngine.InputSystem.Keyboard.current.spaceKey.wasPressedThisFrame)     //ATAQUE
        {
            Instantiate 
                (gun,
          Aimer.position,
          Aimer.rotation);
        }



    }
}
