using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStatsHandlerTest stats;


    private void Awake()
    {
        stats = GetComponent<EnemyStatsHandlerTest>();
    }

    private void EnemyHit()
    {
        //stats.currentStats.maxHealth -= Ÿ�� ���ݷ� �����ֱ�
        if (stats.currentStats.maxHealth <= 0)
        {
            gameObject.SetActive(false);
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
