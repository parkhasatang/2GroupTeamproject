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
        SpawnPosition = new Vector3(-11.48f, 6.46f, -10f);
        enemy.transform.position = SpawnPosition;
        
    }
}
