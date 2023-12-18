using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMoveTest : MonoBehaviour
{
    [SerializeField] Transform[] MonsterPos;
    private EnemyStatsHandlerTest _stats;
    int monsterNum = 0;


    private void Awake()
    {
        _stats = GetComponent<EnemyStatsHandlerTest>();
    }

    void Start()
    {
        transform.position = MonsterPos[monsterNum].transform.position;
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
            (transform.position, MonsterPos[monsterNum].transform.position, _stats.currentStats.speed * Time.deltaTime);
        }
        

        if(transform.position == MonsterPos[monsterNum].transform.position )
            monsterNum++;

        if(monsterNum == MonsterPos.Length)
        {
            gameObject.SetActive(false);
            monsterNum = 0;
        }
            
    }
}
