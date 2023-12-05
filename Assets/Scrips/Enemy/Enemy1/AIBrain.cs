using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody;
    AISensor aISensor;
    public float speed;
    void Start()
    {
        aISensor = transform.GetComponent<AISensor>();
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPos = new Vector2(speed * aISensor.changeDiriction, rigidbody.position.y);
        rigidbody.velocity = newPos;
    }
 
}
