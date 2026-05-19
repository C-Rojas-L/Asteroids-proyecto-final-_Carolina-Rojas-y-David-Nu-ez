using UnityEngine;

public class BOSS : MonoBehaviour
{
   public GameObject gun;
   public Transform Aimer;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate
                  (gun,
            Aimer.position,
            Aimer.rotation);
    }
}
