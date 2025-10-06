using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float salto = 5f;
    public float adelante = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
      
        transform.Translate(Vector3.forward * adelante * Time.deltaTime);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, salto, rb.velocity.z);
        }
    }
}
