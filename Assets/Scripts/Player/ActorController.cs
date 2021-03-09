using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    public IUserInput pi;
    

    public float walkSpeed = 1f;
    public float jumpForce = 1f;

    private Rigidbody2D rigid;
    private Ray2D ray;
    private RaycastHit2D[] hit;

    private bool startJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pi.inputEnabled == false) return;
        if (pi.isJump)
        {
            print("jump");
            startJumping = true;
        }
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(pi.Dvec.x * walkSpeed, rigid.velocity.y);
        if (startJumping)
        {
            rigid.AddForce(new Vector2(0, jumpForce));
            startJumping = false;
        }

    }
}
