using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour   //타워의 선택, 생성, 해제, 그리고 마우스 입력을 감지하는 역할.
{
    public static TowerManager instance; // 싱글톤 인스턴스

    public GameObject towerPrefab; // 타워 프리팹을 인스펙터에서 할당해주세요.
    public LayerMask groundLayer; // 지면을 나타내는 레이어를 인스펙터에서 할당해주세요.

    private GameObject selectedTower; // 선택된 타워를 저장하는 변수
    private Color originalColor; // 선택된 타워의 원래 색상을 저장하는 변수

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
        // 마우스 오른쪽 버튼 클릭 시 타워 선택 해제
        if (Input.GetMouseButtonDown(1))
        {
            DeselectTower();
        }

        // 마우스 왼쪽 버튼 클릭 시 타워 생성 또는 선택
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseInput();
        }
    }


    // 타워를 선택하는 메서드
    public void SelectTower(GameObject tower)
    {
        DeselectTower(); // 이미 선택된 타워가 있을 경우 선택 해제
        selectedTower = tower;
        originalColor = tower.GetComponent<Renderer>().material.color;
        tower.GetComponent<Renderer>().material.color = Color.green; // 선택된 타워의 색상 변경

        
    }

    // 타워를 생성하는 메서드
    private void SpawnTower(Vector3 spawnPosition)
    {
        // 선택된 타워 프리팹을 위치에 생성
        GameObject newTower = Instantiate(selectedTower, spawnPosition, Quaternion.identity);
        DeselectTower(); // 타워 생성 후 선택 해제
    }

    // 선택된 타워를 해제하는 메서드
    private void DeselectTower()
    {
        if (selectedTower != null)
        {
            selectedTower.GetComponent<Renderer>().material.color = originalColor; // 선택된 타워의 색상을 원래 색상으로 변경
            selectedTower = null;
        }
    }


    //마우스 입력 처리 메서드
    private void HandleMouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            //선택된 타워가 있을 경우, 해당 위치에 타워를 생성
            if(selectedTower != null)
            {
                Vector3 spawnPosition = hit.point;
                SpawnTower(spawnPosition);

                // 타워 생성 소리를 재생
                
            }
        }
    }
}
