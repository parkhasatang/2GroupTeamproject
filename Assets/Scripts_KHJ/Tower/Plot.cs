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
        //팝업이 뜨는 코드로 변경.
        //선택한 위치에 타워 둘 수 있게.
        //팝업이 떠있는 동안에는 1번 팝업이 뜨고 있다면 2~9번 안 누르게. (뭐, 이건 눈치 못 챌 수도 있음.
        //탱크가 설치된 위치에는 클릭되면 안됨.
        //뜬다면 업데이트 UI.


        //Debug.Log("Build tower here : " +name);
        if (tower != null) return;


        //GameObject towerToBuild = BuildManager.main.GetSelectedTower();
        TurretShop towerToBuild = BuildManager.main.GetSelectedTower();
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        //tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Tower);
    }
}
