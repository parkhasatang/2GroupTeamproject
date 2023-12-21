using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DHEnemySpawner : MonoBehaviour
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
        SpawnPosition = new Vector3(-11.48f, 6.46f, 0);
        enemy.transform.position = SpawnPosition;
        SoundManager.Instance.PlaySFX("Hit");
    }
}
