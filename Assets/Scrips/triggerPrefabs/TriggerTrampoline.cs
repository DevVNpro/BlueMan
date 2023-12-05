using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrampoline : MonoBehaviour
{
    private Animator animator;
    const string Trap_Active = "Anim1";
    const string Reset = "Default";


    private void Start()
    {
        animator = transform.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.Play(Trap_Active);
        collision.transform.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 25f, 0);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(ResetAnimator());
    }
    IEnumerator ResetAnimator()
    {
        yield return new WaitForSeconds(0.3f);
        animator.Play(Reset);
    }
}
