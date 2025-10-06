using UnityEngine;
using UnityEngine.SceneManagement;
public class CUBO : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
