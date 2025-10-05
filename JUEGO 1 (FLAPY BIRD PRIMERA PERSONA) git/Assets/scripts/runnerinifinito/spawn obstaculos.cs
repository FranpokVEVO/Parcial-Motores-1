using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobstaculos : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform Player;
    public float spawnInterval = 2f;
    public float spawnDistance = 40f;
    public float minY = 0f;
    public float maxY = 12f;

    private float timer = 0f;

    void Update()
    {
        if (Player == null) return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            Vector3 spawnPos = Player.position + Player.forward * spawnDistance;
            spawnPos.y = Random.Range(minY, maxY);
Quaternion rotacion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(obstaclePrefab, spawnPos, rotacion);
        }
    }

}
