using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    private Rigidbody2D rg2d;
    private Animator animaton;
    private SpriteRenderer Spid;
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;

    void Start()
    {
        rg2d =GetComponent<Rigidbody2D>();
        animaton = GetComponent<Animator>();
        Spid = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }
    public float speed = 5f;
    private float X = 0;


    private enum MovermentState {idle, running, jumping,falling }

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            SoundManager.Instance.PlayVFXMusic("Jumping");
            rg2d.velocity = new Vector3(0, 20, 0);
        }
        
        X = Input.GetAxisRaw("Horizontal");
        rg2d.velocity = new Vector2(X * speed, rg2d.velocity.y);

        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        MovermentState state;
        if (X > 0f)
        {
            state = MovermentState.running;
            Spid.flipX = false;
        }
        else if (X < 0f)
        {
            state = MovermentState.running;
            Spid.flipX = true;
        }
        else
        {
            state = MovermentState.idle;
        }
       
       if(rg2d.velocity.y > .1f)
        {
            state = MovermentState.jumping;
        }
       else if(rg2d.velocity.y < -.1f) {
            state = MovermentState.falling;
        }
        animaton.SetInteger("state", ((int)state));
        
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
   
}
