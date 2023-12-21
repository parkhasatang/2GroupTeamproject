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
        enemy.tag = "Enemy";
        enemy.GetComponent<EnemyStatsHandlerTest>().UpdateEnemyStats(); // 한번에 다 초기값으로 초기화 시킴
        SpawnPosition = poolManager.wayPoint[0].position;
        enemy.transform.position = SpawnPosition;
        
    }
}
