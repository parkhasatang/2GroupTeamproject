using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMove : MonoBehaviour
{
    private PoolManager poolManager;
    private EnemyStatsHandlerTest _stats;
    [SerializeField] private PlayerHP playerHP;
    int monsterNum = 0;


    private void Awake()
    {
        _stats = GetComponent<EnemyStatsHandlerTest>();
        poolManager = GetComponentInParent<PoolManager>();
    }

    void Start()
    {
        transform.position = poolManager.wayPoint[monsterNum].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movepath();
    }

    public void Movepath()
    {
        if (gameObject.activeSelf)
        {
            transform.position = Vector2.MoveTowards
            (transform.position, poolManager.wayPoint[monsterNum].transform.position, _stats.currentStats.speed * Time.deltaTime);
        }


        if (transform.position == poolManager.wayPoint[monsterNum].transform.position)
            monsterNum++;

        if (monsterNum == poolManager.wayPoint.Length)
        {
            
            gameObject.SetActive(false);
            monsterNum = 0;
            playerHP.TakeDamage(1);
        }

    }

    
}
