using System;
using UnityEngine;

[Serializable]
public class TurretShop
{
    public string name;
    public int cost;
    public GameObject prefab;

    public TurretShop(string _name, int _cost, GameObject _prefab)
    {
        name = _name;
        cost = _cost;
        prefab = _prefab;
    }

}
