using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxMonster : MonoBehaviour
{
    public Vector3 vectorMove;
    private Rigidbody2D rigidbody2D;
    public float speedRotate;
    private void Start()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //  transform.rotation += Quaternion.Euler(new Vector3(0, 0, 25f));
            //  rigidbody2D.rotation += speedRotate;
            transform.Rotate(new Vector3(0f, 0f, 400f));
            rigidbody2D.velocity = vectorMove.normalized * speedRotate;
           // rigidbody2D.AddForce(vectorMove*100);
        }

    }
}
