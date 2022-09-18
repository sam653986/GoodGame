using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float moveSpeed = 2.5f;


    public Rigidbody2D rb;
    public Animator anim;

    Vector2 move;

    private void Update()
    {

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", move.x);
        anim.SetFloat("Vertical", move.y);
        anim.SetFloat("Speed", move.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
