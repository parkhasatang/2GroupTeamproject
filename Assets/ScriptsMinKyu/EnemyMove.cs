using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
