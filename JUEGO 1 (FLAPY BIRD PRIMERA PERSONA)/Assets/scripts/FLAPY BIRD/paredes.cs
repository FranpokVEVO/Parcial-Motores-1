using UnityEngine;

public class paredes : MonoBehaviour
{
    public Transform player;
    public float fixedX = 0f;
    public float fixedY = 6f;
    public float height = 12f;

    void Update()
    {
        if (player == null) return;

        // Seguir al jugador en Z manteniendo X e Y fijos
        transform.position = new Vector3(fixedX, fixedY, player.position.z);

        // Ajustar tamaño del BoxCollider
        BoxCollider bc = GetComponent<BoxCollider>();
        if (bc != null) bc.size = new Vector3(1f, height, 1f);
    }
}
