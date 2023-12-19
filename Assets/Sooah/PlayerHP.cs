using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private Image imageScreen; // ��üȭ���� ���� ������ �̹���
    [SerializeField] private float maxHP = 20; // �ִ� ü��
    private float currentHP; // ���� ü��

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP; // ���� ü���� �ִ� ü�°� ���� ����
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage; // ���� ü�¿��� ������ ��ŭ ����

        StopCoroutine("HitAlphaAnimation");
        StartCoroutine("HitAlphaAnimation");

        if(currentHP <= 0) // ü���� 0�Ǹ� ���ӿ���
        {

        }
    }

    private IEnumerator HitAlphaAnimation()
    {
        Color color = imageScreen.color;
        color.a = 0.4f;
        imageScreen.color = color;

        while (color.a >= 0.0f) //  ������ 0%�� �ɶ����� ����
        {
            color.a -= Time.deltaTime;
            imageScreen.color = color;

            yield return null;
        }
    }
}
