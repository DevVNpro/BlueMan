using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private float timeLimid;

    private void Update()
    {
        this.TurnOffUI();
    }
    protected void TurnOffUI()
    {
        this.time += Time.deltaTime;
        if (this.time < this.timeLimid) return;
        transform.gameObject.SetActive(false);

    }

}
