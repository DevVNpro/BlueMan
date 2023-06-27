using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSaw : MonoBehaviour
{
    public float speed = 2f;
    public Transform saw;
    // Update is called once per frame
    private void Start()
    {
        saw.GetComponent<Transform>();
    }
    void Update()
    {
        saw.Rotate(0, 0, speed * 360 * Time.deltaTime);
    }
}
