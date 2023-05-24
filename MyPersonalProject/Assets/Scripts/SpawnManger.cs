using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] enamyPrefab;
    private int enamyCount;
    private float SpawnRange = 5;
    private int waveNumber = 3;

     

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnamyWave(waveNumber);
    }
    void SpawnEnamyWave(int enamiesToSpawn)
    {
        for (int i = 0; i < enamiesToSpawn; i++)
        {
            int randomEnamy = Random.Range(0, enamyPrefab.Length);
            Instantiate(enamyPrefab[randomEnamy], GenerateSpawnPosition(), enamyPrefab[randomEnamy].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
       enamyCount = FindObjectsOfType<Enemy>().Length;
       if(enamyCount==0)
        {
            waveNumber++;
            SpawnEnamyWave(waveNumber);
        } 
    }
    private Vector3 GenerateSpawnPosition()
    {
        float SpawnPoSX = Random.Range(-SpawnRange, SpawnRange);
        float SpawnPoSZ = Random.Range(-SpawnRange, SpawnRange);
        Vector3 randomPoS = new Vector3(SpawnPoSX, 0, SpawnPoSZ);
        return randomPoS;
    }
}
