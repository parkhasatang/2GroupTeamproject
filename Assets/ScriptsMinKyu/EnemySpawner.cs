using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Vector3 SpawnPosition;
    public PoolManager poolManager;
    private float timer = 0;
    public float spawnInterval;




    private void Update()
    {
        if (UIManager.instance.GameTime > 0)
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                SpawnEnemy();

                timer = 0f;
            }
        }
        else return;
    }

    private void SpawnEnemy()
    {
        GameObject enemy = poolManager.Get(Random.Range(0,2));
        enemy.tag = "Enemy";
        enemy.GetComponent<EnemyStatsHandlerTest>().UpdateEnemyStats(); // �ѹ��� �� �ʱⰪ���� �ʱ�ȭ ��Ŵ
        SpawnPosition = poolManager.wayPoint[0].position;
        enemy.transform.position = SpawnPosition;
        
    }

    public void SpawnBoss()
    {
        GameObject enemy = poolManager.Get(2);
        enemy.tag = "Enemy";
        enemy.GetComponent<EnemyStatsHandlerTest>().UpdateEnemyStats(); // �ѹ��� �� �ʱⰪ���� �ʱ�ȭ ��Ŵ
        SpawnPosition = poolManager.wayPoint[0].position;
        enemy.transform.position = SpawnPosition;

    }
}
