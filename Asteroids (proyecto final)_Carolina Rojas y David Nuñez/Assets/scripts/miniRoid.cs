using UnityEngine;

public class miniRoid : MonoBehaviour
{

    public Transform spawnpos;
    public GameObject subAsteroid;
    Rigidbody2D rb;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pew"))
        {

            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(Random.insideUnitCircle.normalized * 6f, ForceMode2D.Impulse);

                Destroy(gameObject);
        }


    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Random.insideUnitCircle.normalized * 6f, ForceMode2D.Impulse);
    }


}