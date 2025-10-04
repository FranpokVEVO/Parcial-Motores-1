using UnityEngine;
using TMPro;

public class aro : MonoBehaviour
{
    public float speed = 5f;
    public static int score = 0;
    private Transform player;
    private TextMeshProUGUI scoreText;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        scoreText = GameObject.FindGameObjectWithTag("Puntaje")?.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (player != null)
            transform.position += player.forward * speed * Time.deltaTime;

        if (scoreText != null)
            scoreText.text = "Puntaje: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("GAME OVER");
            Destroy(other.gameObject);
            Time.timeScale = 0f;
        }
    }
}
