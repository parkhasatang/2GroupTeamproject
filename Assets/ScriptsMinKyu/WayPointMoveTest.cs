using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WayPointMoveTest : MonoBehaviour
{
    private PoolManager poolManager;
    private EnemyStatsHandlerTest _stats;
    int monsterNum = 0;


    private void Awake()
    {
        _stats = GetComponentInParent<EnemyStatsHandlerTest>();
        poolManager = GetComponentInParent<PoolManager>();
    }

    void Start()
    {
        transform.parent.position = poolManager.wayPoint[monsterNum].position;
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
            //오브젝트 회전
            Vector3 directionToTarget = poolManager.wayPoint[monsterNum].position - gameObject.transform.position;
            if (monsterNum == 1)
            {
                Quaternion rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
                gameObject.transform.rotation = rotation;
            }
            else if (monsterNum == 2)
            {
                Quaternion rotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
                gameObject.transform.rotation = rotation;
            }
            else if (monsterNum == 3)
            {
                Quaternion rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
                gameObject.transform.rotation = rotation;
            }
            // 오브젝트 이동
            gameObject.transform.parent.position = Vector3.MoveTowards
            (gameObject.transform.parent.position, poolManager.wayPoint[monsterNum].transform.position, _stats.currentStats.speed * Time.deltaTime);
        }
        

        if(transform.parent.position == poolManager.wayPoint[monsterNum].transform.position )
            monsterNum++;

        if(monsterNum == poolManager.wayPoint.Length)
        {
            gameObject.SetActive(false);
            ResetWayPoint();
        }
        
    }

    public void ResetWayPoint()
    {
        monsterNum = 0;
    }
    
}
