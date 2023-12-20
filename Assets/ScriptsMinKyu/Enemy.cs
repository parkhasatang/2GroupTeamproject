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

    private void Awake()
    {
        wayPointMoveTest = GetComponent<WayPointMoveTest>();
        stats = GetComponent<EnemyStatsHandlerTest>();
        animator = GetComponentInChildren<Animator>();
        /*OnEnemyHit += EnemyHit;*/
    }

    public void EnemyHit(int dmg)
    {
        stats.currentStats.maxHealth -= dmg;// Ÿ�� ���ݷ��̶� �������ֱ�.
        if (stats.currentStats.maxHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        animator.SetBool("IsDead", true);
        stats.currentStats.speed = 0;
        gameObject.tag = "Dead";
        wayPointMoveTest.ResetWayPoint();
        yield return new WaitForSeconds(deathDelay);
        gameObject.SetActive(false);
    }


    //���⿡�� �׾����� ������ �ø��� ����� ����������� �غ���.
    internal bool Contains(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    

    internal void Remove(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    

    
}
