    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] protected GameObject messageBox;
    [SerializeField] protected Cherrycollect cherrys;
    private bool completeGame = false;
    protected int checkCountCherry;

    protected virtual void ResetCheckCountCherry()
    {
      //for override
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cherrys.countCherry == this.checkCountCherry)
        {
            if (collision.gameObject.name == "Player" && !completeGame)
            {
                SoundManager.Instance.PlayVFXMusic("Finish");
                completeGame = true;
                Invoke("NextLevel", 2f);

            }
        }
        else messageBox.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        messageBox.SetActive(false);
    }
    protected virtual void NextLevel()
    {
        ScenesManager.Instance.NextLevel();
        //SoundManager.Instance.PlayThemeMusic("BackgroundMusic2");

    }

}
