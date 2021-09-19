using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaurusMove : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float moveSpeed;
    public SpriteRenderer render;
    public bool isLeft;
    // Update is called once per frame
    void Update()
    {
        if(isLeft)
        {
            render.flipX = false;
            rigid.velocity = Vector2.left * moveSpeed;
        }
        else
        {
            render.flipX = true;
            rigid.velocity = Vector2.right * moveSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            isLeft = !isLeft;
        }
    }
}
