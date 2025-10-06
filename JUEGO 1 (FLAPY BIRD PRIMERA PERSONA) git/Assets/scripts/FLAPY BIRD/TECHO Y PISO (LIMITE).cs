using UnityEngine;

public class TECHO_Y_PISO_LIMITE : MonoBehaviour
{
 public Transform player;
    public float pisoY = 0f;
    public float techoY = 12f;

    void Update()
    {
        if (player == null) return;

      
        if (gameObject.name == "PISO 2")
        {
            transform.position = new Vector3(player.position.x, pisoY, player.position.z);
        }
        else if (gameObject.name == "PISO 1")
        {
            transform.position = new Vector3(player.position.x, techoY, player.position.z);
        }
    }
}
