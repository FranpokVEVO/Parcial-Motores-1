using UnityEngine;

public class mov_jugador : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public float velocidad = 5f;

    void Update()
    {
        // Obtener input
        float horizontal = Input.GetAxis("Horizontal"); // A/D o flechas izquierda/derecha
        float vertical = Input.GetAxis("Vertical");     // W/S o flechas arriba/abajo
        
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");     

        // Mover el jugador
       
        Vector3 movimiento = new Vector3(horizontal, 0f, vertical); 
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}