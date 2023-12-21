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
        enemy.GetComponent<EnemyStatsHandlerTest>().UpdateEnemyStats(); // �ѹ��� �� �ʱⰪ���� �ʱ�ȭ ��Ŵ
        SpawnPosition = poolManager.wayPoint[0].position;
        enemy.transform.position = SpawnPosition;
        
    }
}
