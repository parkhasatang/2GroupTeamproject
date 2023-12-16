using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyStatsTest
{
    [Range (0, 100)] public int maxHealth;
    [Range(0f, 10f)] public float speed;
}
