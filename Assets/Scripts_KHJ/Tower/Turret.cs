using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Turret : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform turretRotationPoint;


    [Header("Attribute")]
    [SerializeField] private float targetingRange = 5f; //���� ����


    private void OnDrawGizmosSelected() //���� ����, ��ġ.
    {
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }

}
