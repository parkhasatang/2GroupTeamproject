using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStatsHandlerTest stats;
    private Animator animator;
    public Action OnEnemyHit;

    private void Awake()
    {
        stats = GetComponent<EnemyStatsHandlerTest>();
        animator = GetComponentInChildren<Animator>();
        OnEnemyHit += EnemyHit;
    }

    private void EnemyHit()
    {
        stats.currentStats.maxHealth -= 10;// 타워 공격력이랑 연결해주기.
        if (stats.currentStats.maxHealth <= 0)
        {
            gameObject.SetActive(false);//1초뒤에 해주기 죽는 모션 표현하기
            animator.SetBool("IsDead", true);
        }
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
