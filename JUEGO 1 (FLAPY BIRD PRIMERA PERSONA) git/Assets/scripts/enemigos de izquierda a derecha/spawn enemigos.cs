using UnityEngine;

public class spawnenemigos : MonoBehaviour
{
    public GameObject objetoParaSpawn;   
    public float intervalo = 2f;         
    public float minZ = -3f;            
    public float maxZ = 3f;             
    public float offsetY = 5f;        
    public float posX = 0f;             

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
        Vector3 posicionSpawn = new Vector3(posX,transform.position.y + offsetY,Random.Range(minZ, maxZ));

        Instantiate(objetoParaSpawn, posicionSpawn, Quaternion.identity);
    }
}
