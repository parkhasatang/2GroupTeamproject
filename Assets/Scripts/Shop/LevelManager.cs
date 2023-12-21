using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        currency = 100;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (amount <= currency)
        {   //아이템을 사다.
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("골드가 부족하여 구매할 수 없습니다.");
            return false;
        }
        //[SerializeField] private int currencyWorth = 50; //적을 쓰러트리면 들어오는 골드.
        //LevelManager.main.IncreaseCurrency(currencyWorth);

    }

}
