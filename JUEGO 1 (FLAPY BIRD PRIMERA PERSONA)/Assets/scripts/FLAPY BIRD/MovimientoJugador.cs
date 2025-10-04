using UnityEngine;
using UnityEngine.Animations;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 1.0f;
    public float salto = 1.0f;
    public Rigidbody COLISION;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        COLISION = GetComponent<Rigidbody>();
    }

    public float adelante = 5f;
    void Update()
    {
        transform.Translate(Vector3.forward * adelante * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        COLISION.linearVelocity = new Vector3(horizontal * speed, COLISION.linearVelocity.y);


        if (Input.GetKey(KeyCode.Space))
        {
            COLISION.linearVelocity = new Vector2(COLISION.linearVelocity.x, salto);

        }
    }
}
