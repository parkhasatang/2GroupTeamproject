using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStatsHandlerTest stats;
    private Animator animator;
    /*public Action<int> OnEnemyHit;*/
    private float deathDelay = 2f;
    private WayPointMoveTest wayPointMoveTest;
    private BulletTestMinKyu bulletTest;
    public bool IsBoss;

    private void Awake()
    {
        wayPointMoveTest = GetComponentInChildren<WayPointMoveTest>();
        stats = GetComponent<EnemyStatsHandlerTest>();
        animator = GetComponentInChildren<Animator>();
        /*OnEnemyHit += EnemyHit;*/
    }

    public void EnemyHit(int dmg)
    {
        stats.currentStats.maxHealth -= dmg;// 타워 공격력이랑 연결해주기.
        if (stats.currentStats.maxHealth <= 0)
        {
            StartCoroutine(Die(20));
        }
    }

    IEnumerator Die(int gold)
    {
        animator.SetBool("IsDead", true);
        stats.currentStats.speed = 0;
        if (IsBoss)
        {
            UIManager.instance.StageClear();
        }
        gameObject.tag = "Dead";
        SoundManager.Instance.PlaySFX("Coin");
        UIManager.instance.playerGold.GoldPlus(gold);
        wayPointMoveTest.ResetWayPoint();
        yield return new WaitForSecondsRealtime(deathDelay);
        gameObject.SetActive(false);
    }


    //여기에는 죽었을때 점수를 올리는 방법을 구독방식으로 해보자.
    internal bool Contains(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    

    internal void Remove(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    

    
}
