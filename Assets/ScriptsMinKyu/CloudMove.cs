using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CloudMove : MonoBehaviour
{
    public float speed = 0.7f;
    public float targetX = -11f;

    void Update()
    {
        MoveLeft();
    }

    void MoveLeft()
    {
        // 현재 위치에서 왼쪽 방향으로 이동
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= targetX)
        {
            ModifyXPosition();
        }
    }

    void ModifyXPosition()
    {
        // 특정 위치에 도달하면 x 값을 수정
        float newX = 11f;
        Vector2 newPosition = new Vector2(newX, transform.position.y);
        transform.position = newPosition;
    }
}
