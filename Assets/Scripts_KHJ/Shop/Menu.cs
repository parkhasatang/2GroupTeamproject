using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Menu : MonoBehaviour   //���� ��� �κ��̶� ���� ����. �� ����Ʈ���� ���� ���.
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;


    private void OnGul()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
    }

    public void SetSelected()
    {
        
    }
}
