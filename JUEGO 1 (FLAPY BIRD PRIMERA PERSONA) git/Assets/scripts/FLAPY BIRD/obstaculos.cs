using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform player;
    public float spawnInterval = 2f;
    public float spawnDistance = 40f;
    public float minY = 0f;
    public float maxY = 12f;

    private float timer = 0f;

    void Update()
    {
        if (player == null) return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            Vector3 spawnPos = player.position + player.forward * spawnDistance;
            spawnPos.y = Random.Range(minY, maxY);

            GameObject aro = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);

            Rigidbody rb = aro.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
                rb.useGravity = false;
            }
        }
    }
}
