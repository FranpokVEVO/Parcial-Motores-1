using UnityEngine;

public class mov_jugador : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
     
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");     

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical); 
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}