using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBrainBox : MonoBehaviour
{
    public Vector3 vectorMove;
    private Rigidbody2D rigidbody2D;
    public float speed;
   AISensor aISensor;

    float rotate;
    public bool canMove;
    void Start()
    {
       aISensor = transform.GetComponent<AISensor>();
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        canMove = true;

    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            StartCoroutine(MoveBox());
        }
    }
    IEnumerator MoveBox()
    {
        canMove = false;
        DOTweenModulePhysics2D.DORotate(rigidbody2D, rotate, 1f);
        if (aISensor.changeDiriction==1)
        {
            rotate -= 90;
        }
        else if(aISensor.changeDiriction ==-1)
        {
            rotate += 90;
        }
        rigidbody2D.velocity = aISensor.changeDiriction * speed * vectorMove.normalized;
        yield return new WaitForSeconds(1f);
        canMove = true;

    }
}
