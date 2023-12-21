using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTestMinKyu : MonoBehaviour
{
    // ���ݷ�, �����Ÿ�, ������Ÿ��, (��������, ���ݼӼ�) ���ʹ̼�ġ, ��ġ�� ���ݹ��� ���̰�
    public int AttackDamage; //���ݷ�
    public float AttackRange; //���ݹ���
    public float AttackCooltime; //�� ���ݰ��� ��Ÿ��(���� 10��)
    private float CurrentCooldown = 0f; // �ǽð����� �پ��� ���� ��Ÿ��
    public GameObject bulletPrefab;
    Collider2D closestEnemy = null;
    float closestDistance = float.MaxValue;

    Vector3 spawnPosition;

    private void Start()
    {
        spawnPosition = transform.position;
    }


    private void Update()
    {
        closestDistance = float.MaxValue;

        CurrentCooldown -= Time.deltaTime; //�ǽð����� ��Ÿ�� ����.
        if (CurrentCooldown <= 0) //��Ÿ���� 0�̵Ǹ� ���ݽ���
        {
            Attack();
            CurrentCooldown = AttackCooltime; //������ ��Ÿ�� �ٽõ��ư�����
        }
        RotateGun();
    }

    private void Attack()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange);

        closestEnemy = null;

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
                }
            }

        }
        if (closestEnemy != null)
        {
            // Ÿ������ �Ѿ� ����
            Vector3 spawnPosition = transform.position;
            BulletTestMinKyu bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity).GetComponent<BulletTestMinKyu>();
            bullet.SetTarget(closestEnemy.transform, AttackDamage);
            SoundManager.Instance.PlaySFX("Shoot");
        }
    }

    private void RotateGun()
    {
        if (closestEnemy != null)
        {
            Vector2 directionToEnemy = closestEnemy.transform.position - transform.position;
            float angle = Mathf.Atan2(directionToEnemy.y, directionToEnemy.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
            transform.position = spawnPosition;
        }
    }


}
