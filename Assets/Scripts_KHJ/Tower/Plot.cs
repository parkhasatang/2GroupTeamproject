using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    [Header("Referneces")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject tower;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter() //���콺�� �����ٴ�� Ÿ���� �� �� �ִ� ��ġ�� ���� ����.
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown() //���콺�� Ŭ���ϸ�, Ÿ���� �����ȴ�.
    {
        //Debug.Log("Build tower here : " +name);
        if (tower != null) return;


        //GameObject towerToBuild = BuildManager.main.GetSelectedTower();
        TurretShop towerToBuild = BuildManager.main.GetSelectedTower();
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        //tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Tower);
    }
}
