using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WayPointMoveTest : MonoBehaviour
{
    private PoolManager poolManager;
    private EnemyStatsHandlerTest _stats;
    int monsterNum = 1;


    private void Awake()
    {
        _stats = GetComponentInParent<EnemyStatsHandlerTest>();
        poolManager = GetComponentInParent<PoolManager>();
    }

    private void OnEnable()
    {
        ResetWayPoint();
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
            transform.rotation = poolManager.wayPoint[monsterNum - 1].rotation;
            // 오브젝트 이동
            gameObject.transform.parent.position = Vector3.MoveTowards
            (gameObject.transform.parent.position, poolManager.wayPoint[monsterNum].transform.position, _stats.currentStats.speed * Time.deltaTime);
        }
        

        if(transform.parent.position == poolManager.wayPoint[monsterNum].transform.position )
            monsterNum++;

        if(monsterNum == poolManager.wayPoint.Length)
        {
            transform.parent.gameObject.SetActive(false);
            UIManager.instance.playerHP.TakeDamage(1);
            SoundManager.Instance.PlaySFX("Hit");
        }
        
    }

    public void ResetWayPoint()
    {
        monsterNum = 1;
        transform.parent.position = poolManager.wayPoint[monsterNum - 1].position;       
    }
    
}
