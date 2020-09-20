using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float speed = 10.0f;
    public int Puntaje = 0;
    public int Salud = 3;
    private float vertical, horizontal;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z) );
    }


    private void Update()
    {
        movimiento();
    }

    private void LateUpdate()
    {
       
    }

    public void movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);

        if (rb.transform.position.x > screenBounds.x - 0.5)
        {
            rb.transform.position = new Vector3(screenBounds.x - 0.5f, rb.transform.position.y, rb.transform.position.z);
        }
        else
        {
             rb.velocity = new Vector3(dir.x * speed, dir.y * speed);
        }
    }
    public void Disparar()
    {

    } 
    public void Seleccionar_operacion()
    {

    } 
    public void Muerte()
    {

    }
}
