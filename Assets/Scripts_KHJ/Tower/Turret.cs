using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Turret : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform turretRotationPoint;


    [Header("Attribute")]
    [SerializeField] private float targetingRange = 5f; //공격 범위


    private void OnDrawGizmosSelected() //범위 색상, 위치.
    {
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }

}
