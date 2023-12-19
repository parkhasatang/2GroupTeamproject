using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UIManager : MonoBehaviour
{
    public PlayerHP playerHP;
    public PlayerGold playerGold;
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
}
