using UnityEngine;
using UnityEngine.SceneManagement;
public class CUBO : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // El jugador debe tener tag "Player"
        {
            Destroy(collision.gameObject); // Destruye al jugador
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia la escena
        }
    }

    // Si el cubo o el jugador tienen collider como Trigger, usar este en lugar de OnCollisionEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
