using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerSpawner : MonoBehaviour
{

    [SerializeField]
    public GameObject towerPrefab;


    public void SpawnTower(Transform tileTransform)
    {
        Tile tile = tileTransform.GetComponent<Tile>();
        
        //Ÿ�� ���� ���� ���� Ȯ��.
        //���� ��ġ�� Ÿ���� ���� ���� �ȵǴϱ�, Ÿ���� �ִٸ� �Ǽ� x
        if(tile.IsBuildTower == true)
        {
            return;
        }

        //Ÿ���� �Ǽ��Ǿ� �������� ����
        tile.IsBuildTower = true;

        //������ Ÿ���� ��ġ�� Ÿ�� �Ǽ�.
        Instantiate(towerPrefab, tileTransform.position, Quaternion.identity);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
