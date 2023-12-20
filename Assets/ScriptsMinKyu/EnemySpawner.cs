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
        SpawnPosition = new Vector3(-11.48f, 6.46f, -10f);
        enemy.transform.position = SpawnPosition;
        
    }
}
