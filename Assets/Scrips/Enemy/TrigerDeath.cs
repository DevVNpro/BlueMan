using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerDeath : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;

    private void Start()
    {
        animator = transform.parent.GetComponent<Animator>();
        rigidbody2D = transform.parent.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.parent.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            animator.StopPlayback();
            // rigidbody2D.AddForce(Vector3.up * 2f);
            boxCollider2D.enabled = false;
            rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
            collision.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            rigidbody2D.velocity = new Vector3(0, 20, 0);
            rigidbody2D.gravityScale = 50;
        }
    }


}
