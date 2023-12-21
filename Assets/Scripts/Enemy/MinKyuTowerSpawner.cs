using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinKyuTowerSpawner : MonoBehaviour
{
    public GameObject[] TowersType;
    public void TowerSpawn(int WhatTower)
    {
        Transform selectedTransform = MinKyuUiManager.I.PlotTransform[MinKyuUiManager.I.SelectPlotData];
        if (WhatTower == 1)
        {
            if (UIManager.instance.playerGold.CurrentGold >= 50)
            {
                Instantiate(TowersType[WhatTower - 1], selectedTransform.position, Quaternion.identity);
                UIManager.instance.playerGold.GoldMinus(50);
                SoundManager.Instance.PlaySFX("Tower");
                selectedTransform.GetComponent<PlotMinKyu>().isOccupied = true;// ø∑±∏∏Æ ≈Î∑Œ ∂’¿∫∞≈¿”.
                MinKyuUiManager.I.CloseTowerShopUi();
            }
            else return;
        }
        else if (WhatTower == 2)
        {
            if (UIManager.instance.playerGold.CurrentGold >= 100)
            {
                Instantiate(TowersType[WhatTower - 1], selectedTransform.position, Quaternion.identity);
                UIManager.instance.playerGold.GoldMinus(100);
                SoundManager.Instance.PlaySFX("Tower");
                selectedTransform.GetComponent<PlotMinKyu>().isOccupied = true;// ø∑±∏∏Æ ≈Î∑Œ ∂’¿∫∞≈¿”.
                MinKyuUiManager.I.CloseTowerShopUi();
            }
            else return;
        }
        else if (WhatTower == 3)
        {
            if (UIManager.instance.playerGold.CurrentGold >= 150)
            {
                Instantiate(TowersType[WhatTower - 1], selectedTransform.position, Quaternion.identity);
                UIManager.instance.playerGold.GoldMinus(150);
                SoundManager.Instance.PlaySFX("Tower");
                selectedTransform.GetComponent<PlotMinKyu>().isOccupied = true;// ø∑±∏∏Æ ≈Î∑Œ ∂’¿∫∞≈¿”.
                MinKyuUiManager.I.CloseTowerShopUi();
            }
            else return;
        }       
    }
}
