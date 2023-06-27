using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] protected Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(Startgame);
    }
    public void Startgame()
    {
        ScenesManager.Instance.Startgame();
    }
   
}
