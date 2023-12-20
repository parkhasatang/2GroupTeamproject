using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour   //���콺 Ŭ���� 'TowerManager'�� ���õ� Ÿ���� �˸���, �ش� ��ġ�� Ÿ���� ��ġ�ϴ� ����.
{
    //�˾��� �ߴ� �ڵ�� ����.
    //������ ��ġ�� Ÿ�� �� �� �ְ�. ��ġ ��, ����â�� ���������.
    //�˾��� ���ִ� ���ȿ��� 1�� �˾��� �߰� �ִٸ� 2~9�� �� ������. (��, �̰� ��ġ �� ç ���� ����.
    //��ũ�� ��ġ�� ��ġ���� Ŭ���Ǹ� �ȵ�.
    //��ٸ� ������Ʈ UI.

    private void OnMouseDown()
    {
        // �÷��� Ŭ���Ǹ� TowerManager�� ���õ� Ÿ���� �˸�
        TurretShop selectedTurret = BuildManager.main.GetSelectedTower();

        // ���õ� Ÿ���� ���� ��� TowerManager�� ������ ��û
        if (selectedTurret != null)
        {
            TowerManager.instance.SelectTower(selectedTurret.GetTurretPrefab());
        }
    }

    //[Header("Referneces")]
    //[SerializeField] private SpriteRenderer sr;
    //[SerializeField] private Color hoverColor;
    //[SerializeField] private GameObject towerShopPrefab; // Ÿ�� ���� â �������� �ν����Ϳ��� �Ҵ��ϱ�.
    //[SerializeField] private AudioClip towerPlacementSound; // Ÿ�� ��ġ �Ҹ��� �ν����Ϳ��� �Ҵ��ϱ�.

    //private GameObject tower;
    //private Color startColor;

    //private void Start()
    //{
    //    startColor = sr.color;
    //}

    //private void OnMouseEnter() //���콺�� �����ٴ�� Ÿ���� �� �� �ִ� ��ġ�� ���� ����.
    //{
    //    sr.color = hoverColor;
    //}

    //private void OnMouseExit()
    //{
    //    sr.color = startColor;
    //}



    //private void BuildTower(TurretShop turretShop)
    //{
    //    // BuildManager���� ���õ� Ÿ�� ������ ������ ���鿡 Ÿ���� ��ġ
    //    GameObject turretPrefab = turretShop.GetTurretPrefab();
    //    if (turretPrefab != null)
    //    {
    //        // ���⿡�� ���ϴ� ��ġ ���� ������ �߰��� �� �ֽ��ϴ�.
    //        Instantiate(turretPrefab, transform.position, Quaternion.identity);

    //        // Ÿ�� ���� �Ҹ��� ���
    //        AudioManager.instance.PlaySfx(AudioManager.Sfx.Tower);
    //    }
    //}

       
        //if (tower != null) return;
        //TurretShop towerToBuild = BuildManager.main.GetSelectedTower();
        //tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);

        
    
}
