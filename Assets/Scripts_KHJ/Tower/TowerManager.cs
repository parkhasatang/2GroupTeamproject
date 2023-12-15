using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerManager : MonoBehaviour
{
    public GameObject towerPrefab;
    public BoxCollider spawnArea; // BoxCollider�� ����ϵ��� ����
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
                if (spawnArea.bounds.Contains(hit.point))
                {
                    Vector3 spawnPosition = hit.point;
                    SpawnTower(spawnPosition);
                }
            }
        }
    }

    void SpawnTower(Vector3 spawnPosition)
    {
        // Ÿ�� �������� ���� ��ġ�� ����
        Debug.Log("Ÿ��" + spawnPosition);
        Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}
