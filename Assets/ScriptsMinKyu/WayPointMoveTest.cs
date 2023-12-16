using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMoveTest : MonoBehaviour
{
    [SerializeField] Transform[] MonsterPos;
    [SerializeField] float speed = 5f;
    int monsterNum = 0;

    // Start is called before the first frame update
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
            (transform.position, MonsterPos[monsterNum].transform.position, speed * Time.deltaTime);
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
