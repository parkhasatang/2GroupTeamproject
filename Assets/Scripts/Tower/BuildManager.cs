using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour   //�������� ������ Ÿ���� ��ȯ�ϰ�, ������ Ÿ���� �����ϴ� ����.
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
