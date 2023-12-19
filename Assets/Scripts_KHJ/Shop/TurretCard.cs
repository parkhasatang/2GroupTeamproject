using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurretCard : MonoBehaviour
{
    public static Action<TurretSettings> OnPlaceTurret;

    [SerializeField] private Image turretImage;
    [SerializeField] private TextMeshProUGUI turretCost;

    public TurretSettings TurretLoaded { get; set; }

    public void SetupTurretButton(TurretSettings turretSettings)
    {
        TurretLoaded = turretSettings;
        turretImage.sprite = turretSettings.TurretShopSprite;
        turretCost.text = turretSettings.TurretShopCost.ToString();
    }

    public void PlaceTurret()
    {
        //if(CurrencySysyem.Instance.TotalCoins >= TurretLoaded.TurretShopCost)
        //{
        //    CurrencySystem.Instance.RemoveCoins(TurretLoaded.TurretShopCost);
        //    UIManager.instance.CloseTurretShopPanel();
        //    OnPlaceTurret?.Invoke(TurretLoaded);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
