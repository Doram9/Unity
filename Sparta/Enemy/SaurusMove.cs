using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaurusMove : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float moveSpeed;
    public SpriteRenderer render;
    bool isLeft;
    bool isDead = false;
    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }
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

    public void Ondamage()
    {
        rigid.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        BoxCollider2D col = gameObject.GetComponent<BoxCollider2D>();
        col.enabled = false;
        render.color = new Color(1, 1, 1, 0.5f);
        isDead = true;
        GameManager.I.Score += 20;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            isLeft = !isLeft;
        }
    }
}
