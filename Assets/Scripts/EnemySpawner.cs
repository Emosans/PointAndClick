using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float xPos;
    public float zPos;
    private int totalWaves=5;
    private int enemiesSpawnedPerWave = 2;
    private int currentWaves = 0;
    private int enemiesSpawnedInWave = 0;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(WavesOfEnemy());
    }

    public IEnumerator WavesOfEnemy()
    {
        while(currentWaves < totalWaves)
        {
            yield return StartCoroutine(EnemySpawn());
            currentWaves++;
            yield return new WaitForSeconds(5f);
        }
        
    }

    public IEnumerator EnemySpawn()
    {
        enemiesSpawnedInWave = 0;
        while(enemiesSpawnedInWave < enemiesSpawnedPerWave)
        {
            xPos = Random.Range(-21, 26);
            zPos = Random.Range(-19, -66);

            Instantiate(Enemy, new Vector3(xPos, -10.92f, zPos), Quaternion.identity);
            enemiesSpawnedInWave++;
            yield return new WaitForSeconds(0.1f);
        }
        
    }
}
