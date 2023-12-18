using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UIManager : MonoBehaviour
{
    public Tilemap tilemap;
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
}
