using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMoverment : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    private int currentWayponitIndex = 0;
    [SerializeField] private float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(waypoint[currentWayponitIndex].transform.position, transform.position)<.1f){
            currentWayponitIndex++;
            if(currentWayponitIndex >= waypoint.Length)
            {
                currentWayponitIndex = 0;
            }
            
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[currentWayponitIndex].transform.position, Time.deltaTime * speed);

    }
}
