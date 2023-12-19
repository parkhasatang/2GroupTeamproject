using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // 공격력, 사정거리, 공격쿨타임, (공격유형, 공격속성) 에너미서치, 설치전 공격범위 보이게
    public int AttackDamage = 10; //공격력
    public float AttackRange = 10f; //공격범위
    public float AttackCooltime = 1f; //매 공격간의 쿨타임(현재 10초)
    private float CurrentCooldown = 0f; // 실시간으로 줄어드는 공격 쿨타임
    public GameObject bulletPrefab;
    

    private void Update()
    {
        CurrentCooldown -= Time.deltaTime; //실시간으로 쿨타임 감소.
        if (CurrentCooldown <= 0) //쿨타임이 0이되면 공격실행
        {
            Attack();
            CurrentCooldown = AttackCooltime; //공격후 쿨타임 다시돌아가게함
        }
    }

    private void Attack()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                // 타워에서 총알 생성
                Vector3 spawnPosition = transform.position;
                Bullet bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity).GetComponent<Bullet>();
                bullet.SetTarget(collider.transform, AttackDamage);
                Debug.Log("타워의 공격");
            }
       
        }
    }

    ////Collider2D[] Enemies = 
    ////foreach(Collider2D Enemy in enemies)
    //}
    public void OnDrawGizmosSelected()  //공격범위 확인용
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }

}
