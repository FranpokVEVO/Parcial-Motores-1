using UnityEngine;

public class TECHO_Y_PISO_LIMITE : MonoBehaviour
{
    public float velocidadZ = 5f;
    void Update()
    {
         transform.position += new Vector3(0f, 0f, velocidadZ * Time.deltaTime);
    }
}
