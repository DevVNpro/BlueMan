using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenuManager : MonoBehaviour
{
    [SerializeField] protected Button playAgain;
    [SerializeField] protected Button exit;
    private void Start()
    {
        playAgain.onClick.AddListener(PlayAgain);
        exit.onClick.AddListener(ExitGame);
        
    }
    public void PlayAgain()
    {
        ScenesManager.Instance.PlayAgain();
    }
    public void ExitGame()
    {
        ScenesManager.Instance.ExitGame();
    }



}
