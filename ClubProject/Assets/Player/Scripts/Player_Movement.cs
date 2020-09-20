using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{


    private Rigidbody2D rb;
    public float speed = 0.0f;
    private Vector2 moveVelocity;
    private Animator anim;


    // Use this for initialization
    void Start()
    {

        //Obtains info from the player sprite
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Keeps the sprite upright
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        //Decides the direction of the desired velocity
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        //Allows the animator ro know if the sprite is moving
        if(moveVelocity.magnitude > 0.01f)
        {
            anim.SetBool("Moving", true);
        }
        else{
            anim.SetBool("Moving", false);
        }

    }

    void FixedUpdate()
    {
        //Should flip the sprite to face the direction its moving
        //NOT Currently working
        if (Input.GetAxisRaw("Horizontal") >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Input.GetAxisRaw("Horizontal") <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
