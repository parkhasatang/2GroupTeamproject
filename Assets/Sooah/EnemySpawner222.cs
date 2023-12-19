using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner222 : MonoBehaviour
{
    Vector3 SpawnPosition;
    public PoolManager poolManager;


    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
        AudioManager.instance.PlayBgm(true);
    }

    private void SpawnEnemy()
    {
        GameObject enemy = poolManager.Get(Random.Range(0, 2));
        SpawnPosition = new Vector3(-11.48f, 6.46f, 0);
        enemy.transform.position = SpawnPosition;
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
    }
}
