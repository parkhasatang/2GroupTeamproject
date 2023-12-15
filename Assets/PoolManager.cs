using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int enemyType)
    {
        GameObject select = null;

        foreach (GameObject item in pools[enemyType])
        {
            if (!item.activeSelf) // 오브젝트가 꺼져있다면
            {
                select = item;
                // if문으로 Enemy 타입에 따른 속도설정
                
                select.SetActive(true);
                break;
            }
        }
        if (!select) //풀에 꺼진 오브젝트가 없다면
        {
            select = Instantiate(prefabs[enemyType], transform);
            pools[enemyType].Add(select);
        }
        return select;
    }
}
