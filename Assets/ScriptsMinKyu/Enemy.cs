using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //여기에는 죽었을때 점수를 올리는 방법을 구독방식으로 해보자.
    internal bool Contains(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    private EnemyStatsHandlerTest stats;

    internal void Remove(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    private void Awake()
    {
        stats = GetComponent<EnemyStatsHandlerTest>();
    }

    private void EnemyHit()
    {
        //stats.currentStats.maxHealth -= 타워 공격력 적어주기
        if (stats.currentStats.maxHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
