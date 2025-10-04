using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed = 5f;
    public float salto = 5f;
    public float adelante = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento hacia adelante constante
        transform.Translate(Vector3.forward * adelante * Time.deltaTime);

        // Movimiento horizontal (izq-der)
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, rb.velocity.z);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, salto, rb.velocity.z);
        }
    }
}
