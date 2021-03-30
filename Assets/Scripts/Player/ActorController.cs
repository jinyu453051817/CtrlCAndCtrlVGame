using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    public IUserInput pi;
    private CopyManager cm;
    private Animator anim;
    
    public float walkSpeed = 1f;
    public float jumpForce = 1f;
    public bool isGround = false;
    public bool canShowText = false;

    private Rigidbody2D rigid;
    private Ray2D ray;
    private RaycastHit2D hit;

    private bool startJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        cm = GameObject.Find("ShowText").GetComponent<CopyManager>();
        cm.gameObject.SetActive(false);
        anim = transform.Find("brave").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pi.inputEnabled == false) return;
        if (pi.isJump && isGround)
        {
            print("jump");
            startJumping = true;
        }

        if (pi.Dright>0 && transform.localScale.x<0 || pi.Dright < 0 && transform.localScale.x > 0)
        {
            Flip();
        }

        if (canShowText)
        {
            if (pi.showText)
            {
                cm.gameObject.SetActive(!cm.gameObject.activeSelf);
            }

        }
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(pi.Dvec.x * walkSpeed, rigid.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(rigid.velocity.x));
        
        if (startJumping)
        {
            rigid.AddForce(new Vector2(0, jumpForce));
            startJumping = false;
        }

        hit = Physics2D.Raycast( transform.position, Vector2.down, 0.5f,LayerMask.GetMask("Ground"));
        Debug.DrawLine(transform.position, (Vector2)transform.position + Vector2.down);
        if (hit.collider != null)
        {
            isGround = true;

        }
        else
        {
            isGround = false;
        }
        
    }

    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
    }
}
