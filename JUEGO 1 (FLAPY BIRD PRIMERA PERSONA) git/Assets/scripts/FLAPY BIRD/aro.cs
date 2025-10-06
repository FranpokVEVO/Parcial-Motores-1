using UnityEngine;

public class AroTextMesh : MonoBehaviour
{
    public float speed = 5f; 
    public int puntos = 1;  
    public static int score = 0; 
    private Transform player; 
    private TextMesh scoreText; 
    private GameObject centroTrigger; 

   

    void Update()
    {
        
        if (player != null)
            transform.position += player.forward * speed * Time.deltaTime;
       
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
