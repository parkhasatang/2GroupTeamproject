using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour   //Ÿ���� ����, ����, ����, �׸��� ���콺 �Է��� �����ϴ� ����.
{
    public static TowerManager instance; // �̱��� �ν��Ͻ�

    public GameObject towerPrefab; // Ÿ�� �������� �ν����Ϳ��� �Ҵ����ּ���.
    public LayerMask groundLayer; // ������ ��Ÿ���� ���̾ �ν����Ϳ��� �Ҵ����ּ���.

    private GameObject selectedTower; // ���õ� Ÿ���� �����ϴ� ����
    private Color originalColor; // ���õ� Ÿ���� ���� ������ �����ϴ� ����

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // ���콺 ������ ��ư Ŭ�� �� Ÿ�� ���� ����
        if (Input.GetMouseButtonDown(1))
        {
            DeselectTower();
        }

        // ���콺 ���� ��ư Ŭ�� �� Ÿ�� ���� �Ǵ� ����
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseInput();
        }
    }


    // Ÿ���� �����ϴ� �޼���
    public void SelectTower(GameObject tower)
    {
        DeselectTower(); // �̹� ���õ� Ÿ���� ���� ��� ���� ����
        selectedTower = tower;
        originalColor = tower.GetComponent<Renderer>().material.color;
        tower.GetComponent<Renderer>().material.color = Color.green; // ���õ� Ÿ���� ���� ����

        
    }

    // Ÿ���� �����ϴ� �޼���
    private void SpawnTower(Vector3 spawnPosition)
    {
        // ���õ� Ÿ�� �������� ��ġ�� ����
        GameObject newTower = Instantiate(selectedTower, spawnPosition, Quaternion.identity);
        DeselectTower(); // Ÿ�� ���� �� ���� ����
    }

    // ���õ� Ÿ���� �����ϴ� �޼���
    private void DeselectTower()
    {
        if (selectedTower != null)
        {
            selectedTower.GetComponent<Renderer>().material.color = originalColor; // ���õ� Ÿ���� ������ ���� �������� ����
            selectedTower = null;
        }
    }


    //���콺 �Է� ó�� �޼���
    private void HandleMouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            //���õ� Ÿ���� ���� ���, �ش� ��ġ�� Ÿ���� ����
            if(selectedTower != null)
            {
                Vector3 spawnPosition = hit.point;
                SpawnTower(spawnPosition);

                // Ÿ�� ���� �Ҹ��� ���
                
            }
        }
    }
}
