using UnityEngine;
using UnityEngine.SceneManagement;

public class Admin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (
            GameObject.FindGameObjectsWithTag("asteroid")
            .Length == 0
        )
        {
            SceneManager.LoadScene(1);
        }
    }
}
