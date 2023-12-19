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
        stats.currentStats.maxHealth -= 10;// Ÿ�� ���ݷ��̶� �������ֱ�.
        if (stats.currentStats.maxHealth <= 0)
        {
            gameObject.SetActive(false);//1�ʵڿ� ���ֱ� �״� ��� ǥ���ϱ�
            animator.SetBool("IsDead", true);
        }
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
