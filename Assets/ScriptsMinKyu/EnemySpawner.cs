using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Vector3 SpawnPosition;
    public PoolManager poolManager;


    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    private void SpawnEnemy()
    {
        GameObject enemy = poolManager.Get(Random.Range(0,2));
        SpawnPosition = new Vector3(0, 0, 0);
        enemy.transform.position = SpawnPosition;
    }
}
