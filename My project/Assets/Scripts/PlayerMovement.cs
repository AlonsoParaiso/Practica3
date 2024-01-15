using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public KeyCode rightKey, leftKey, jumpKey;
    public float speed, jumpForce, rayDistance;
    public LayerMask groundMask;// mascara de colisiones que queremos
    private SpriteRenderer _rend;
    private Animator _animator;
    private Rigidbody2D rb;
    private Vector2 dir;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector2.zero;
        if (Input.GetKey(rightKey))
        {
            _rend.flipX = false;
            dir = Vector2.right;
        }
        else if (Input.GetKey(leftKey))
        {
            _rend.flipX = true;
            dir = new Vector2(-1, 0);
        }

        isJumping = false;

        if (Input.GetKey(jumpKey))
        {
            isJumping = true;
        }

        #region Animaciones
        if (dir!= Vector2.zero) 
        {
            _animator.SetBool("IsWalking", true);  
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
        #endregion
    }

    private void FixedUpdate()
    {
        // if (dir != Vector2.zero)
        {
            float currentYvel = rb.velocity.y;
            Vector2 nVel = dir * speed;
            nVel.y = currentYvel;
            rb.velocity = nVel;

        }

        if (isJumping && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce * rb.gravityScale, ForceMode2D.Impulse);
            isJumping = false;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHits = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundMask);



        if (raycastHits)
        {
            return true;
        }


        return false;
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }
}
