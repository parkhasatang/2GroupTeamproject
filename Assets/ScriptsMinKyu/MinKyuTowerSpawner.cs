using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinKyuTowerSpawner : MonoBehaviour
{
    public GameObject[] TowersType;
    public void TowerSpawn(int WhatTower)
    {
        Transform selectedTransform = MinKyuUiManager.I.PlotTransform[MinKyuUiManager.I.SelectPlotData];
        Instantiate(TowersType[WhatTower - 1], selectedTransform.position, Quaternion.identity);
        selectedTransform.GetComponent<PlotMinKyu>().isOccupied = true;// ø∑±∏∏Æ ≈Î∑Œ ∂’¿∫∞≈¿”.
        MinKyuUiManager.I.CloseTowerShopUi();
    }
}
