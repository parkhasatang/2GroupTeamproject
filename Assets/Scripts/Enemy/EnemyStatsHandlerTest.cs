using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatsHandlerTest : MonoBehaviour
{
    [SerializeField] EnemyStatsTest baseStats;
    public EnemyStatsTest currentStats { get; set; }

    private void Awake()
    {
        UpdateEnemyStats();
    }

    public void UpdateEnemyStats()
    {
        currentStats = new EnemyStatsTest();
        currentStats.maxHealth = baseStats.maxHealth;
        currentStats.speed = baseStats.speed;
    }
}
