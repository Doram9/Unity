using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtanJump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;
    public int jumpCount = 0;
    // Update is called once per frame
    void Update()
    {
        if (jumpCount < 2 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpCount++;
            rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jumpCount = 0;
    }

}