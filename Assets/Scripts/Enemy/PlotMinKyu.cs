using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotMinKyu : MonoBehaviour
{

    public bool isOccupied;

    private void OnMouseDown()
    {
        if (isOccupied) return;
        MinKyuUiManager.I.OpenTowerShopUi();
        MinKyuUiManager.I.SelectPlotData = gameObject.transform.GetSiblingIndex();
    }
}
