using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject trapPrefab;
    private float SpawnRange = 50;
   

     

    // Start is called before the first frame update
    void Start()
    {

    }
   
    

    // Update is called once per frame
    void Update()
    {
      
    }
    private Vector3 GenerateSpawnPosition()
    {
        float SpawnPoSX = Random.Range(-SpawnRange, SpawnRange);
        float SpawnPoSZ = Random.Range(-SpawnRange, SpawnRange);
        Vector3 randomPoS = new Vector3(SpawnPoSX, 0, SpawnPoSZ);
        return randomPoS;
    }
}
