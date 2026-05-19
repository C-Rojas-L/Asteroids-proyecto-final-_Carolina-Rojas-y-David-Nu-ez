using UnityEngine;

public class spawner : MonoBehaviour
{
    //public Transform spawnpos;
    public GameObject Asteroid;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector2 posicion = new Vector2(
                Random.Range(-5f, 4f),       //X
                Random.Range(-8f, 8f));     //Y

            Instantiate(
                Asteroid,
                posicion,
                Quaternion.identity);     
        }

    
    }
}

