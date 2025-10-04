using UnityEngine;

public class spawndecajas : MonoBehaviour
{
    public GameObject objetoParaSpawn;
    public float intervalo = 2f;
    public float minX = -3f;
    public float maxX = 3f;
    public float offsetY = 5f;

    private float contadorTiempo;

    void Update()
    {
        contadorTiempo += Time.deltaTime;
        if (contadorTiempo >= intervalo)
        {
            contadorTiempo = 0f;
            Instantiate(objetoParaSpawn,new Vector3(Random.Range(minX, maxX),transform.position.y + offsetY,transform.position.z),Quaternion.identity);
        }
    }
}
