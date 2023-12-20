using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinKyuUiManager : MonoBehaviour
{
    public static MinKyuUiManager I;

    public GameObject TowerShopUi;
    public Transform[] PlotTransform;

    public int SelectPlotData;
    

    private void Awake()
    {
        I = this;
    }


    public void OpenTowerShopUi()
    {
        TowerShopUi.SetActive(true);
    }
    public void CloseTowerShopUi()
    {
        TowerShopUi.SetActive(false);
    }
}
