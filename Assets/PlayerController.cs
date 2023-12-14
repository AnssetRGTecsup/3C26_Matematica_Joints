using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 10f;

    private Rigidbody2D rb;
    private bool enSuelo = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
            Debug.Log("Toca piso");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = false;
            Debug.Log("Sale del suelo");
        }
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2(movimientoHorizontal, 0f);
        rb.velocity = new Vector2(movimiento.x * velocidadMovimiento, rb.velocity.y);

        // Salto
        if (enSuelo && Input.GetButtonDown("Jump"))

        {
            Debug.Log("Saltando");
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}

