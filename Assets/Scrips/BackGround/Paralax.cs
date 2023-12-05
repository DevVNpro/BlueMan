using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed;
    public Transform player;

    void Update()
    {
        transform.position = new Vector3(player.position.x * speed, (player.position.y*0.1f)-5f,transform.position.z);
        
    }
}
