using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour   //상점에서 선택한 타워를 반환하고, 선택한 타워를 설정하는 역할.
{
    public static BuildManager main;    

    [Header("References")]
    [SerializeField] private TurretShop[] turretShop;

    private int selectedTower = 0;

    private void Awake()
    {
        main = this;
    }

    public TurretShop GetSelectedTower()
    {
        return turretShop [selectedTower];
    }

    public void SetSelectedTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }

}
