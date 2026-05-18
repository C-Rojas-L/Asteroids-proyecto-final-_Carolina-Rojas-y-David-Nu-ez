using UnityEngine;

public class pew : MonoBehaviour
{
    public float speed = 9f;
    public float lifeSpan = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity =
           transform.up * speed;

        Destroy(gameObject, lifeSpan);



    }

}
