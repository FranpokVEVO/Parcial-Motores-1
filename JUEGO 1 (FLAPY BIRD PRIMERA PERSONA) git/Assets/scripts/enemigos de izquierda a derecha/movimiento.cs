using UnityEngine;

public class movimiento : MonoBehaviour
{
public float velocidad = 5f; 

    void Update()
    {

        
        float movimiento = Input.GetAxis("Horizontal"); 


        
        transform.Translate(Vector3.right * movimiento * velocidad * Time.deltaTime);
    }
}
