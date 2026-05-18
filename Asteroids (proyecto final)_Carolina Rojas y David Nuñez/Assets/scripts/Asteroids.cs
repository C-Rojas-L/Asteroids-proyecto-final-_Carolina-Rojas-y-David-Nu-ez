using UnityEngine;

public class Destruibles : MonoBehaviour
{
    public GameObject subAsteroid;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pew"))
        {
            Instantiate(subAsteroid);
                Destroy(gameObject);
    
        
        
        }
    
    
    
    }
}