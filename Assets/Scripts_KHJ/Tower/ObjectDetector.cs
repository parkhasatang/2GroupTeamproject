using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] 
    private TowerSpawner towerSpawner;

    private Camera mainCamera;  //그냥 카메라를 적는 것보다 변수를 적어놓는 게 호율적이라고 한다.
    private Ray ray;
    private RaycastHit hit;

    private void Awake()
    {   
        //mainCamera 태그를 가지고 있는 오브젝트 탐색 후, Camera 컴포넌트 정보 전달.
        mainCamera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 클릭 시 타워 생성.
        if(Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //광선에 부딪힌 오브젝트의 태그가 "Tile"이면
                if(hit.transform.CompareTag("Tile"))
                {
                    //타워를 생성하는 SpawnTower()호출
                    towerSpawner.SpawnTower(hit.transform);
                }

                
            }
        }
    }
}
