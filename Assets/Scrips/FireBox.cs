using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBox : MonoBehaviour
{
    Animator animator;
    private const string anim = "Anim_FireBox1";
    private const string animDefault = "Anim_Default_FireBox";
    bool active;
    void Start()
    {
        animator = transform.GetComponent<Animator>();
        active = true;
    }
    private void Update()
    {
        if (active)
        {
            StartCoroutine(StartActive());

        }
    }
    IEnumerator StartActive()
    {
        active = false;
        animator.Play(anim);
        yield return new WaitForSeconds(3f);
        animator.Play(animDefault);
        yield return new WaitForSeconds(2f);
        active = true;
    }
   


}
