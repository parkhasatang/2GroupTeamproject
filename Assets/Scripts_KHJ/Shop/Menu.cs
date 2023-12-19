using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Menu : MonoBehaviour   //유저 골드 부분이랑 연결 예정. 적 쓰러트리고 얻은 골드.
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
