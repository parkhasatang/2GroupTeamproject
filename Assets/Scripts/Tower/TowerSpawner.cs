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
        
        //타워 생성 가능 여부 확인.
        //같은 위치에 타워가 여러 개면 안되니까, 타워가 있다면 건설 x
        if(tile.IsBuildTower == true)
        {
            return;
        }

        //타워가 건설되어 있음으로 설정
        tile.IsBuildTower = true;

        //선택한 타일의 위치에 타워 건설.
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
