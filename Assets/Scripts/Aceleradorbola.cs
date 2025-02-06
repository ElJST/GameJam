using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceleradorbola : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerzaMaxEmpuje = 1000f;
    public float aceleracion = 100f;
    private float fuerzaAcumulada = 000f;
    private float fuerzaActual = 000f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        fuerzaAcumulada = 500f;
        AplicarFuerza(other, fuerzaActual);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        fuerzaAcumulada += aceleracion * Time.deltaTime;

        // Limita la fuerza acumulada a la fuerza máxima
        fuerzaAcumulada = Mathf.Min(fuerzaAcumulada, fuerzaMaxEmpuje);

        // Aplica la fuerza acumulada al objeto
        fuerzaActual = Mathf.Lerp(fuerzaActual, fuerzaAcumulada, Time.deltaTime);

        AplicarFuerza(other, fuerzaActual);
    }

    private void AplicarFuerza(Collider2D other, float fuerza)
    {
        // Verifica si el objeto en la zona tiene un componente Rigidbody2D
        if (other.CompareTag("bola"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddForce(Vector2.left * fuerza);
            }
        }
    }
}