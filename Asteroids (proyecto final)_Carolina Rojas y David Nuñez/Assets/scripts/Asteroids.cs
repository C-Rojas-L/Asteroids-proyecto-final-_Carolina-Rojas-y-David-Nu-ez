using UnityEngine;

public class Destruibles : MonoBehaviour
{

    public Transform spawnpos;
    public GameObject subAsteroid;
    Rigidbody2D rb;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Random.insideUnitCircle.normalized * 6f, ForceMode2D.Impulse);

        if (collision.gameObject.CompareTag("pew"))
        {
            Vector2 offset = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f));
            
            



            for (int i = 0; i < 3; i++)
            {



               /* Instantiate(subAsteroid,
                (Vector2)transform.position + offset, spawnpos.rotation);
                
                */

                GameObject fragmento =
            Instantiate(subAsteroid,
                        (Vector2)transform.position + offset,
                        Quaternion.identity);

                Rigidbody2D rb = fragmento.GetComponent<Rigidbody2D>();

                rb.AddForce(Random.insideUnitCircle * 4f,
                            ForceMode2D.Impulse);
                Destroy(gameObject);
            }



        }
    
     

   

    }
    void Start()                    
    {
    rb=GetComponent<Rigidbody2D>();
    rb.AddForce(new Vector2(Random.Range(-5f, 5f), Random.Range(-5, 5f)), ForceMode2D.Impulse);
    }


}