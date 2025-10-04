using UnityEngine;

public class spawnenemigos : MonoBehaviour
{

    public GameObject objetoParaSpawn;   // Prefab a spawnear
    public float intervalo = 2f;         // Tiempo entre spawns
    public float minZ = -3f;             // Límite mínimo en Z
    public float maxZ = 3f;              // Límite máximo en Z
    public float offsetY = 5f;           // Altura extra respecto al spawner
    public float posX = 0f;              // Posición fija en X

    private float contadorTiempo;

    void Update()
    {
        contadorTiempo += Time.deltaTime;

        if (contadorTiempo >= intervalo)
        {
            SpawnObjeto();
            contadorTiempo = 0f;
        }
    }

    void SpawnObjeto()
    {
        // Posición aleatoria en Z dentro del rango que vos quieras
        Vector3 posicionSpawn = new Vector3(
            posX,                                     // X fija o elegida
            transform.position.y + offsetY,           // Altura
            Random.Range(minZ, maxZ)                  // Z aleatoria
        );

        Instantiate(objetoParaSpawn, posicionSpawn, Quaternion.identity);
    }
}
