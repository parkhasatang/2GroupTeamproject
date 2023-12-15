using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] 
    private TowerSpawner towerSpawner;

    private Camera mainCamera;  //�׳� ī�޶� ���� �ͺ��� ������ ������� �� ȣ�����̶�� �Ѵ�.
    private Ray ray;
    private RaycastHit hit;

    private void Awake()
    {   
        //mainCamera �±׸� ������ �ִ� ������Ʈ Ž�� ��, Camera ������Ʈ ���� ����.
        mainCamera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� Ŭ�� �� Ÿ�� ����.
        if(Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //������ �ε��� ������Ʈ�� �±װ� "Tile"�̸�
                if(hit.transform.CompareTag("Tile"))
                {
                    //Ÿ���� �����ϴ� SpawnTower()ȣ��
                    towerSpawner.SpawnTower(hit.transform);
                }

                
            }
        }
    }
}
