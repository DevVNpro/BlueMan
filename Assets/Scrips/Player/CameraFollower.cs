using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Transform tranform;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =  new Vector3(player.position.x,player.position.y+3,-14.4f);
    }
}
