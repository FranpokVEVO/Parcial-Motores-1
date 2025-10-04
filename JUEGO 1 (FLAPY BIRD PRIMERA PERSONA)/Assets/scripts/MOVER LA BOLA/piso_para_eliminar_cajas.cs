using UnityEngine;

public class piso_para_eliminar_cajas : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CUBO"))
        {
            Destroy(collision.gameObject);
        }
    }
}
