using UnityEngine;

public class barrera : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala") || collision.gameObject.CompareTag("enemigo"))
        {

            Destroy(collision.gameObject); 
        }
    }
}
