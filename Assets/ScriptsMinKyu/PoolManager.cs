using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pools;

    public Transform[] wayPoint;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List<GameObject>();
        }
    }

    private void Start()
    {
        UIManager.instance.stageClearAction += ResetPools;
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

    public void ResetPools() // ������Ʈ �ʱ�ȭ�Լ�
    {
        for(int i = 0;i < pools.Length;i++) // ����Ʈ�� ������ �ִ� �迭�� ������ �ؼ� ����Ʈ�� �̾ƿ�
        {
            for (int j = 0;j < pools[i].Count; j++) // ���� ����Ʈ�� �����ؼ� ������Ʈ�� �̾ƿ�
            {
                pools[i][j].SetActive(false); // ������Ʈ�� �¿�Ƽ�긦 ����
            }
        }
    }
}
