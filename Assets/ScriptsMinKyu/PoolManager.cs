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

    public void ResetPools() // 오브젝트 초기화함수
    {
        for(int i = 0;i < pools.Length;i++) // 리스트를 가지고 있는 배열에 접근을 해서 리스트를 뽑아옴
        {
            for (int j = 0;j < pools[i].Count; j++) // 이제 리스트에 접근해서 오브젝트를 뽑아옴
            {
                pools[i][j].SetActive(false); // 오브젝트의 셋엑티브를 꺼줌
            }
        }
    }
}
