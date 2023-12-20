using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour   //마우스 클릭시 'TowerManager'에 선택된 타워를 알리고, 해당 위치에 타워를 설치하는 역할.
{
    //팝업이 뜨는 코드로 변경.
    //선택한 위치에 타워 둘 수 있게. 배치 후, 상점창은 사라져야함.
    //팝업이 떠있는 동안에는 1번 팝업이 뜨고 있다면 2~9번 안 누르게. (뭐, 이건 눈치 못 챌 수도 있음.
    //탱크가 설치된 위치에는 클릭되면 안됨.
    //뜬다면 업데이트 UI.

    private void OnMouseDown()
    {
        // 플롯이 클릭되면 TowerManager에 선택된 타워를 알림
        TurretShop selectedTurret = BuildManager.main.GetSelectedTower();

        // 선택된 타워가 있을 경우 TowerManager에 생성을 요청
        if (selectedTurret != null)
        {
            TowerManager.instance.SelectTower(selectedTurret.GetTurretPrefab());
        }
    }

    //[Header("Referneces")]
    //[SerializeField] private SpriteRenderer sr;
    //[SerializeField] private Color hoverColor;
    //[SerializeField] private GameObject towerShopPrefab; // 타워 상점 창 프리팹을 인스펙터에서 할당하기.
    //[SerializeField] private AudioClip towerPlacementSound; // 타워 설치 소리를 인스펙터에서 할당하기.

    //private GameObject tower;
    //private Color startColor;

    //private void Start()
    //{
    //    startColor = sr.color;
    //}

    //private void OnMouseEnter() //마우스를 가져다대면 타워를 둘 수 있는 위치가 색이 변함.
    //{
    //    sr.color = hoverColor;
    //}

    //private void OnMouseExit()
    //{
    //    sr.color = startColor;
    //}



    //private void BuildTower(TurretShop turretShop)
    //{
    //    // BuildManager에서 선택된 타워 정보를 가져와 지면에 타워를 설치
    //    GameObject turretPrefab = turretShop.GetTurretPrefab();
    //    if (turretPrefab != null)
    //    {
    //        // 여기에서 원하는 위치 등의 설정을 추가할 수 있습니다.
    //        Instantiate(turretPrefab, transform.position, Quaternion.identity);

    //        // 타워 생성 소리를 재생
    //        AudioManager.instance.PlaySfx(AudioManager.Sfx.Tower);
    //    }
    //}

       
        //if (tower != null) return;
        //TurretShop towerToBuild = BuildManager.main.GetSelectedTower();
        //tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);

        
    
}
