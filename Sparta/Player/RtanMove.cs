using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtanMove : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float moveSpeed;
    public SpriteRenderer render;
    // Update is called once per frame
    void Update()
    {
        // �⺻ ������ 0 �Դϴ�.
        // Vector2.zero �� Vector2(0f, 0f) �� �����ϴ�
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            render.flipX = true;
            // ���� Ű�� ���� ��쿣 ���� �� Vector2.left �� �̵��մϴ�
            // Vector2.left �� Vector2(-1f, 0f) �� �����ϴ�
            direction = Vector2.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            render.flipX = false;
            // ������ Ű�� ���� ��쿣 ������ �� Vector2.right �� �̵��մϴ�
            // Vector2.right �� Vector2(1f, 0f) �� �����ϴ�
            direction = Vector2.right * moveSpeed;
        }
        direction.y = rigid.velocity.y;
        rigid.velocity = direction;

    }
}
