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

    private void OnMouseEnter() //마우스를 가져다대면 타워를 둘 수 있는 위치가 색이 변함.
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown() //마우스로 클릭하면, 타워가 생성된다.
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
