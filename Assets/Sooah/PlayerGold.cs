using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    [SerializeField] private int currentGold = 100;
    
    public int CurrentGold
    {
        set => currentGold = Mathf.Max(0, value); // 골드의 최소는 0
        get => currentGold;
    }

    private void Start()
    {
        UIManager.instance.stageClearAction += ResetPlayerGold;
    }

    public void GoldPlus(int gold) // 적이 포탑에게 사망했을때 골드 획득함수 불러줌
    {
        CurrentGold += gold;
    }

    public void GoldMinus(int gold) // 포탑을 선택하여 자리지정을 해줬을때 골드 소모함수 불러줌 
    {
        if(CurrentGold < gold)
        {
            return;
        }
        CurrentGold -= gold;
    }

    public void ResetPlayerGold()
    {
        currentGold = 100;
    }
}
