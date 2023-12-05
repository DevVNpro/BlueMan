using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerDeath : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    private Collider2D collider2D;

    private void Start()
    {
        animator = transform.GetComponent<Animator>();
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        collider2D = transform.GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player") && (collision.transform.position.y - transform.position.y>1f))
        {
            if(animator != null)
            {
                animator.StopPlayback();
            }
            AIBrain aIBrain =transform.gameObject.GetComponent<AIBrain>();
            if(aIBrain != null)
            {
                aIBrain.enabled = false;
            }
            collider2D.enabled = false;
            rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
            collision.transform.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4, 0);
            rigidbody2D.velocity = new Vector3(0, 10, 0);
           
        }
    }
   


}
