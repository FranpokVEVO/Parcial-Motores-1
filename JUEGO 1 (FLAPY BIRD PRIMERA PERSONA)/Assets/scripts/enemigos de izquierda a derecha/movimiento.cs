using UnityEngine;

public class movimiento : MonoBehaviour
{
public float velocidad = 5f; // Velocidad de movimiento

    void Update()
    {
        // Obtener el input horizontal (flechas o A/D)
        float movimiento = Input.GetAxis("Horizontal"); 

        // Mover el objeto
        transform.Translate(Vector3.right * movimiento * velocidad * Time.deltaTime);
    }
}
