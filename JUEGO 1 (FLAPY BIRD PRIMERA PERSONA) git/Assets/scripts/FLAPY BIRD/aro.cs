using UnityEngine;

public class AroTextMesh : MonoBehaviour
{
    public float speed = 5f; // velocidad del aro
    public int puntos = 1;   // puntos al pasar por el centro
    public static int score = 0; // puntaje global
    private Transform player; // referencia al jugador
    private TextMesh scoreText; // referencia al texto 3D
    private GameObject centroTrigger; // collider invisible del centro

    void Start()
    {
        // Buscar jugador automáticamente
        // Buscar texto de puntaje (3D TextMesh con tag "Puntaje")
        // Crear un collider interno invisible para el centro
        
    }

    void Update()
    {
        // Movimiento del aro
        if (player != null)
            transform.position += player.forward * speed * Time.deltaTime;
        // Actualizar puntaje
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("GAME OVER");
            Destroy(other.gameObject);
            Time.timeScale = 0f;
        }
    }
}

public class CentroTrigger : MonoBehaviour
{
    public int puntos = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AroTextMesh.score += puntos;
            Debug.Log("Puntaje: " + AroTextMesh.score);
            Destroy(gameObject);
        }
    }
}
