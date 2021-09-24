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
        // 기본 방향은 0 입니다.
        // Vector2.zero 는 Vector2(0f, 0f) 와 같습니다
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            render.flipX = true;
            // 왼쪽 키를 누른 경우엔 왼쪽 즉 Vector2.left 로 이동합니다
            // Vector2.left 는 Vector2(-1f, 0f) 와 같습니다
            direction = Vector2.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            render.flipX = false;
            // 오른쪽 키를 누른 경우엔 오른쪽 즉 Vector2.right 로 이동합니다
            // Vector2.right 는 Vector2(1f, 0f) 와 같습니다
            direction = Vector2.right * moveSpeed;
        }
        direction.y = rigid.velocity.y;
        rigid.velocity = direction;

    }
}
