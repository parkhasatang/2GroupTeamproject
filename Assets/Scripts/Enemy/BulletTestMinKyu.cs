using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTestMinKyu : MonoBehaviour
{
    private Transform target;
    private int damage;
    private List<Bullet> Bullets;
    
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
            target.GetComponent<Enemy>().EnemyHit(damage);
            SoundManager.Instance.PlaySFX("Hit");
            Destroy(gameObject);
        }
    }
}
