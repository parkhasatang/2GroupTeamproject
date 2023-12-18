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
            if (!item.activeSelf) // ������Ʈ�� �����ִٸ�
            {
                select = item;
                // if������ Enemy Ÿ�Կ� ���� �ӵ�����
                
                select.SetActive(true);
                break;
            }
        }
        if (!select) //Ǯ�� ���� ������Ʈ�� ���ٸ�
        {
            select = Instantiate(prefabs[enemyType], transform);
            pools[enemyType].Add(select);
        }
        return select;
    }
}
