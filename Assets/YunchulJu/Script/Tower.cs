using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // ���ݷ�, �����Ÿ�, ������Ÿ��, (��������, ���ݼӼ�) ���ʹ̼�ġ, ��ġ�� ���ݹ��� ���̰�
    public int AttackDamage = 10; //���ݷ�
    public float AttackRange = 10f; //���ݹ���
    public float AttackCooltime = 10f; //�� ���ݰ��� ��Ÿ��(���� 10��)
    public LayerMask EnemyLayer; //���ݹ����� ���� Ž��
    public Transform AttackPoint; //��������
    public float LastAttackTime; //������ ������ �ߵ��� �ð�
    private float CurrentCooldown = 0f; // �ǽð����� �پ��� ���� ��Ÿ��

    private void Update()
    {
        CurrentCooldown -= Time.deltaTime; //�ǽð����� ��Ÿ�� ����.
        if (CurrentCooldown <= 0) //��Ÿ���� 0�̵Ǹ� ���ݽ���
        {
            Attack();
            CurrentCooldown = AttackCooltime; //������ ��Ÿ�� �ٽõ��ư�����
        }
    }

    private void Attack()
    {
        //Collider2D[] Enemies = 
        //foreach(Collider2D Enemy in enemies)
        Debug.Log("Ÿ���� ����");
    }
    public void OnDrawGizmosSelected()  //���ݹ��� Ȯ�ο�
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }

}
