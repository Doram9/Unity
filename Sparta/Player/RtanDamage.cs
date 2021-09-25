using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtanDamage : MonoBehaviour
{

    public BoxCollider2D col1;
    public BoxCollider2D col2;
    public SpriteRenderer render;

    void OnDamage()
    {
        col1.enabled = false;
        col2.enabled = false;
        render.color = new Color(1, 1, 1, 0.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("ÇÇ°Ý");
            OnDamage();
            GameManager.I.GameOver();
        }
    }
}
