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
        // ���� ��ġ���� ���� �������� �̵�
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= targetX)
        {
            ModifyXPosition();
        }
    }

    void ModifyXPosition()
    {
        // Ư�� ��ġ�� �����ϸ� x ���� ����
        float newX = 11f;
        Vector2 newPosition = new Vector2(newX, transform.position.y);
        transform.position = newPosition;
    }
}
