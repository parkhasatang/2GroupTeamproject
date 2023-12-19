using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTestMinKyu : MonoBehaviour
{
    // ���ݷ�, �����Ÿ�, ������Ÿ��, (��������, ���ݼӼ�) ���ʹ̼�ġ, ��ġ�� ���ݹ��� ���̰�
    public int AttackDamage = 10; //���ݷ�
    public float AttackRange = 4f; //���ݹ���
    public float AttackCooltime = 1f; //�� ���ݰ��� ��Ÿ��(���� 10��)
    private float CurrentCooldown = 0f; // �ǽð����� �پ��� ���� ��Ÿ��
    public GameObject bulletPrefab;
    Collider2D closestEnemy = null;
    float closestDistance = float.MaxValue;


    private void Update()
    {
        closestEnemy = null;
        closestDistance = float.MaxValue;

        CurrentCooldown -= Time.deltaTime; //�ǽð����� ��Ÿ�� ����.
        if (CurrentCooldown <= 0) //��Ÿ���� 0�̵Ǹ� ���ݽ���
        {
            Attack();
            CurrentCooldown = AttackCooltime; //������ ��Ÿ�� �ٽõ��ư�����
        }
    }

    private void Attack()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                float distanceToEnemy = Vector2.Distance(transform.position, collider.transform.position);

                // ���� ���� ���� ����� ������ Ȯ��
                if (distanceToEnemy < closestDistance)
                {
                    closestEnemy = collider;
                    closestDistance = distanceToEnemy;
                    Debug.Log("������");
                }
                //// Ÿ������ �Ѿ� ����
                //Vector3 spawnPosition = transform.position;
                //Bullet bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity).GetComponent<Bullet>();
                //bullet.SetTarget(collider.transform, AttackDamage);
                //Debug.Log("Ÿ���� ����");
            }

        }
        if (closestEnemy != null)
        {
            // Ÿ������ �Ѿ� ����
            Vector3 spawnPosition = transform.position;
            BulletTestMinKyu bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity).GetComponent<BulletTestMinKyu>();
            bullet.SetTarget(closestEnemy.transform, AttackDamage);
            Debug.Log("Ÿ���� ����");
        }
    }


    ////Collider2D[] Enemies = 
    ////foreach(Collider2D Enemy in enemies)
    //}
    /*public void OnDrawGizmosSelected()  //���ݹ��� Ȯ�ο�
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }*/
}
