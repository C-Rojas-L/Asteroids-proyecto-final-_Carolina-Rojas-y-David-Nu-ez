using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naveMod : MonoBehaviour
{
    Rigidbody2D ship;

    Transform direction;

    public float rtt = 180;
    float maxSpeed = 4.5f;
    public GameObject gun;
    //public GameObject blast;
    public Transform Aimer;

    Animator anima;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        ship = GetComponent<Rigidbody2D>();
        //rtt = 180;

        anima = GetComponent<Animator>();
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
            ship.AddForce(transform.up * 0.1f, ForceMode2D.Impulse);
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


    private void OnCollisionEnter2D(Collision2D collision)                            //GAME OVER
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {

            //Destroy(gameObject);

            SceneManager.LoadScene(1);

        }
    }
    public void siguiente()
    {
        if (UnityEngine.InputSystem.Keyboard.current.upArrowKey.isPressed)
        {
            anima.SetTrigger("siguiente");
        }
    }

}

