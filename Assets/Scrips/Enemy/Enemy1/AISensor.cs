using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISensor : MonoBehaviour
{
    Vector3 tranformLocalScal = new Vector3();
    public LayerMask layerGround;
    public LayerMask layerPlayer;

    public static int changeDiriction;
    public bool playerInArea;

    public Color GizmosNoTarget = Color.red;
    public Color GizmosTarget = Color.green;


    private void Start() 
    {
        tranformLocalScal = transform.localScale;
        changeDiriction = 1;
}


    // Update is called once per frame
    void Update()
    {
        CheckMove();
        CheckAttack();



      

    }
    public void CheckMove()
    {
        if (Physics2D.Raycast(transform.position, Vector2.right * changeDiriction, .8f, layerGround))
        {
            if (changeDiriction == -1)
            {
                changeDiriction = 1;
            }
            else
            {

                changeDiriction = -1;

            }
            Debug.DrawRay(transform.position, Vector2.right * .8f * changeDiriction, Color.green);
            transform.localScale = new Vector3(tranformLocalScal.x * changeDiriction, tranformLocalScal.y, tranformLocalScal.z);


        }
        else
        {

            Debug.DrawRay(transform.position, Vector2.right * .8f * changeDiriction, Color.red);
        }

    }
    public void CheckAttack()
    {
        if(Physics2D.OverlapBox(transform.position,Vector3.one*5,0f, layerPlayer))
        {
            playerInArea = true;
        }
        else
        {
            playerInArea = false;
        }


    }
    private void OnDrawGizmos()
    {
        Gizmos.color = GizmosNoTarget;
        if (playerInArea)
        {
            Gizmos.color = GizmosTarget;
        }
        Gizmos.DrawCube(transform.position, Vector3.one *4);
    }
}
