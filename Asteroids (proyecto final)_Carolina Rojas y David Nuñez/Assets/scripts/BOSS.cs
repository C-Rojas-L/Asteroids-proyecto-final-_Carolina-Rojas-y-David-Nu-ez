using UnityEngine;
using UnityEngine.Rendering;

public class BOSS : MonoBehaviour
{
   public GameObject gun;
   public Transform Aimer;
    public int move = 5;
    int vidas = 3;
    float cooldown = 2f;
    float timer = 3f;

    Rigidbody2D rb;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.simulated = false;
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown) 
        { 
            Instantiate(gun, Aimer.position, Aimer.rotation);
            timer = 0;
        }        
        

        GetComponent<Rigidbody2D>().linearVelocity =
           -transform.right * move;




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        move = move * -1;

        if (collision.gameObject.CompareTag("pew"))
        {
            move = +1;
            vidas = -1;
            cooldown = 0.5f;
            if (vidas == 0)
            {
                Destroy(gameObject);
                print("waos");


            }

        }

    }


}
