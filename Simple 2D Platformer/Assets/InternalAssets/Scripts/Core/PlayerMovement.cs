using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float jumpForce = 2f;
    public float moveSpeed = 2;

    public SpriteRenderer spriteRenderer;
    public Animator anim;

    private void Update()
    {
        var dirX = Input.GetAxisRaw("Horizontal");
        rb2D.velocity = new Vector2(dirX * moveSpeed, rb2D.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }

        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            spriteRenderer.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
            //spriteRenderer.flipX = true;
        }
    }
}
