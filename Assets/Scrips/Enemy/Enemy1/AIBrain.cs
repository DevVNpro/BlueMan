using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPos = new Vector2(5 * AISensor.changeDiriction, rigidbody.position.y);
        rigidbody.velocity = newPos;
    }
}
