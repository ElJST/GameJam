using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2D;
    private Vector2 input;

    [Header("Movimiento")]  
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadMovimiento;
    [Range(0, 0.5f)][SerializeField] private float suavizadoMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;

    [Header("Salto")]
    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool estaEnSuelo;
    private bool salto=false;

    [Header("Escalar")]
    [SerializeField] private float velocidadEscalar;
    private CapsuleCollider2D capsuleCollider2D;
    private float gravedadInicial;
    private bool escalando;

    private Animator animator;
    private void Start() 
    {
        rb2D = GetComponent<Rigidbody2D>();
        //animator =GetComponent<Animator>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        gravedadInicial = rb2D.gravityScale;
    }
    private void Update() 
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        movimientoHorizontal = input.x * velocidadMovimiento;
        //if(input.x != 0)
        //{
        //    animator.SetBool("Run", true);
        //}
        //else
        //{
        //    animator.SetBool("Run", false);
        //}
        //if (input.y != 0)
        //{
        //    animator.SetBool("Salto", true);
        //}
        //else
        //{
        //    animator.SetBool("Salto", false);
        //}
        if (Input.GetButtonDown("Jump")) 
        {
            salto = true;
            
        }
    }

    private void FixedUpdate() 
    {
        estaEnSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);

        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);

        Escalar();

        salto=false;
    }

    private void Mover(float mover, bool saltar) 
    {
        
        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoMovimiento);

        if ((mover > 0 && !mirandoDerecha))
        {
            Girar();
        }else if(mover<0&&mirandoDerecha){
            Girar();
        }

        if (estaEnSuelo && saltar)
        {
            estaEnSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));
        }
    }

    private void Escalar()
    {
        if ((input.y != 0 || escalando) && (capsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Escaleras"))))
        {
            Vector2 velocidadSubida = new Vector2(rb2D.velocity.x, input.y * velocidadEscalar);
            rb2D.velocity = velocidadSubida;
            rb2D.gravityScale = 0;
            escalando = true;
        }
        else
        {
            rb2D.gravityScale = gravedadInicial;
            escalando = false;
        }

        if (estaEnSuelo)
        {
            escalando = false;
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }
}
