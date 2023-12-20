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
        set => currentGold = Mathf.Max(0, value); // ����� �ּҴ� 0
        get => currentGold;
    }

    public void GoldPlus(int gold) // ���� ��ž���� ��������� ��� ȹ���Լ� �ҷ���
    {
        CurrentGold += gold;
    }

    public void GoldMinus(int gold) // ��ž�� �����Ͽ� �ڸ������� �������� ��� �Ҹ��Լ� �ҷ��� 
    {
        if(CurrentGold < gold)
        {
            return;
        }
        CurrentGold -= gold;
    }
}
