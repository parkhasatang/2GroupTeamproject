using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerManager : MonoBehaviour
{
    public GameObject towerPrefab;
    private Ray ray;
    private RaycastHit hit;

    void Start()
    {
        
    }

    //마우스 왼쪽 클릭 시 타워 생성
    void Update()
    {
        // 마우스 왼쪽 클릭 시 타워 생성
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPosition = hit.point;
                SpawnTower(spawnPosition);
            }
        }
    }

    void SpawnTower(Vector3 spawnPosition)
    {
        // 타워 프리팹을 생성 위치에 생성
        GameObject newTower = Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}
