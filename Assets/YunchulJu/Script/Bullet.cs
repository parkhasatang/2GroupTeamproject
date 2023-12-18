using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    private int damage;
    private List<Bullet> Bullets;

    // Update is called once per frame
    public void SetTarget(Transform _target, int _damage)
    {
        target = _target;
        damage = _damage;
    }
    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 10f);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 0.1f)
        {
            DealDamage();
            Destroy(gameObject); // 적에 도달하면 총알 제거
        }
    }
    void DealDamage()
    {
        Enemy enemy = target.GetComponent<Enemy>();
        if (enemy != null)
        {
            //enemy.TakeDamage(damage);
        }
    }
}
