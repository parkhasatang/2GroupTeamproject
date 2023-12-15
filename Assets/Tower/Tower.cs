using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // 공격력, 사정거리, 공격쿨타임, (공격유형, 공격속성) 에너미서치, 설치전 공격범위 보이게
    public int AttackDamage = 10; //공격력
    public float AttackRange = 10f; //공격범위
    public float AttackCooltime = 10f; //매 공격간의 쿨타임(현재 10초)
    public LayerMask EnemyLayer; //공격범위내 몬스터 탐지
    public Transform AttackPoint; //공격지점
    public float LastAttackTime; //이전에 공격이 발동한 시간
    private float CurrentCooldown = 0f; // 실시간으로 줄어드는 공격 쿨타임

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
        //Collider2D[] Enemies = 
        //foreach(Collider2D Enemy in enemies)
        Debug.Log("타워의 공격");
    }
    public void OnDrawGizmosSelected()  //공격범위 확인용
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }

}
