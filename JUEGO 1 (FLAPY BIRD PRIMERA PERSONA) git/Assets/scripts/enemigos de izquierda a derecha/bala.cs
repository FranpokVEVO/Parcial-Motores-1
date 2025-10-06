using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody balaRb;
    public float power = 100f;
    void Start()
    {
        balaRb = GetComponent<Rigidbody>();
        balaRb.velocity = Vector3.right * power;
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("barrera"))
        {
                        Destroy(gameObject);
        }
    }
}
