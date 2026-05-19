using UnityEngine;

public class bumper : MonoBehaviour
{
    public TipoBumper miTipoDeBumper;
    Rigidbody2D rbAjeno;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (miTipoDeBumper == TipoBumper.Redondo)

        {
            gameObject.AddComponent<CircleCollider2D>();
        }
        else if (miTipoDeBumper == TipoBumper.Cuadrado)
        {
            gameObject.AddComponent<BoxCollider2D>();
        }


        gameObject.AddComponent<CircleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rbAjeno = collision.gameObject.GetComponent<Rigidbody2D>();
        rbAjeno.AddForce(new Vector2(Random.Range(0f, 5f), Random.Range(0, 5f)), ForceMode2D.Impulse);
    }



    // Update is called once per frame
    void Update()
    {

    }
    public enum TipoBumper
    {
        Redondo,
        Cuadrado

    }


}