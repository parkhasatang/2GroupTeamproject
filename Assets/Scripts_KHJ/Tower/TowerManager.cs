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

    //���콺 ���� Ŭ�� �� Ÿ�� ����
    void Update()
    {
        // ���콺 ���� Ŭ�� �� Ÿ�� ����
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
        // Ÿ�� �������� ���� ��ġ�� ����
        GameObject newTower = Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}
