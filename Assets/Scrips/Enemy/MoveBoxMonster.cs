using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MoveBoxMonster : MonoBehaviour
{
    public Vector3 vectorMove;
    private Rigidbody2D rigidbody2D;
    public float speed;
    float rotate;
    private void Start()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        rotate = 90;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DOTweenModulePhysics2D.DORotate(rigidbody2D, rotate, 1f);
            rotate += 90;
            rigidbody2D.velocity = vectorMove.normalized * speed;
        }

    }
}
