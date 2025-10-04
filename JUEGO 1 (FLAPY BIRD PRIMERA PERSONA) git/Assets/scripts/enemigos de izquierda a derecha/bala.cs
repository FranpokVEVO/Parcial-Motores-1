using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody balaRb;
    public float power = 100f;
    public float vida = 5f;
    private float time = 0f;

    [System.Obsolete]
    void Start()
    {
        balaRb = GetComponent<Rigidbody>();
        balaRb.velocity = Vector3.right * power;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= vida)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("barrera"))
        {
                        Destroy(gameObject);
        }
    }
}
